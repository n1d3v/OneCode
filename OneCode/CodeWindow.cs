using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OneCode.UserControls;
using OneCode.Classes;
using System.IO;

namespace OneCode
{
    public partial class CodeWindow : Form
    {
        // References for the native menu bar
        [DllImport("user32.dll")]
        public static extern IntPtr CreateMenu();
        [DllImport("user32.dll")]
        public static extern IntPtr CreatePopupMenu();
        [DllImport("user32.dll")]
        public static extern bool AppendMenu(IntPtr hMenu, uint uFlags, UIntPtr uIDNewItem, string lpNewItem);
        [DllImport("user32.dll")]
        public static extern bool SetMenu(IntPtr hWnd, IntPtr hMenu);
        [DllImport("user32.dll")]
        public static extern bool DrawMenuBar(IntPtr hWnd);

        public const uint MF_STRING = 0x00000000;
        public const uint MF_POPUP = 0x00000010;
        public const uint MF_SEPARATOR = 0x00000800;

        // The code template loaded into the panel
        private CodeTemplate _clickedCodeControl;

        public CodeWindow()
        {
            InitializeComponent();
            CreateNativeMenuBar();
            LoadAccounts();
        }

        private void CreateNativeMenuBar()
        {
            // Why use this instead of a MenuStrip?
            // There is only one reason, it's because it looks better natively on Windows 7 and older.
            // The custom styling it has natively looks amazing and I don't want to lose it.
            IntPtr mainMenu = CreateMenu(); 

            IntPtr fileMenu = CreatePopupMenu();
            AppendMenu(fileMenu, MF_STRING, (UIntPtr)1, "Import OTP codes");
            AppendMenu(fileMenu, MF_STRING, (UIntPtr)2, "Export OTP codes");
            AppendMenu(fileMenu, MF_SEPARATOR, (UIntPtr)3, null);
            AppendMenu(fileMenu, MF_STRING, (UIntPtr)4, "Exit OneCode");

            IntPtr helpMenu = CreatePopupMenu();
            AppendMenu(helpMenu, MF_STRING, (UIntPtr)5, "GitHub Issues");
            AppendMenu(helpMenu, MF_SEPARATOR, (UIntPtr)6, null);
            AppendMenu(helpMenu, MF_STRING, (UIntPtr)7, "About OneCode");

            AppendMenu(mainMenu, MF_POPUP, (UIntPtr)fileMenu.ToInt64(), "File");
            AppendMenu(mainMenu, MF_POPUP, (UIntPtr)helpMenu.ToInt64(), "Help");

            SetMenu(this.Handle, mainMenu);
            DrawMenuBar(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_COMMAND = 0x0111;
            if (m.Msg == WM_COMMAND)
            {
                int id = m.WParam.ToInt32();

                switch (id)
                {
                    case 1:
                        ImportCode importForm = new ImportCode();
                        importForm.Show();
                        break;

                    case 2:
                        MessageBox.Show("This feature is not yet implemented, please come back later when it is, or just never come back!", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case 4:
                        this.Close();
                        break;

                    case 5:
                        Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = "https://github.com/n1d3v/OneCode/issues",
                            UseShellExecute = true
                        });
                        break;

                    case 7:
                        AboutOneCode aboutForm = new AboutOneCode();
                        aboutForm.ShowDialog();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private void LoadAccounts()
        {
            string xmlFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OneCodeAccs.xml");

            if (!File.Exists(xmlFile))
            {
                codeCount.Text = "You have 0 codes available.";
                return;
            }

            string xmlContent = File.ReadAllText(xmlFile, System.Text.Encoding.UTF8).Trim();
            List<AccountData> accounts = DataParser.ParseXml(xmlContent);

            accountsPanel.Controls.Clear();

            int codeCountNum = 0;
            foreach (var acc in accounts)
            {
                var codeControl = new CodeTemplate();
                codeControl.SetAccount(acc.Name, acc.Secret, 6);

                codeCountNum++;

                AttachRightClickHandler(codeControl, CodeControl_MouseUp);
                accountsPanel.Controls.Add(codeControl);
            }
            codeCount.Text = $"You have {codeCountNum} codes available.";

            int totalHeight = accountsPanel.Padding.Top;
            foreach (Control ctrl in accountsPanel.Controls) { totalHeight += ctrl.Height + ctrl.Margin.Top + ctrl.Margin.Bottom; }
            totalHeight += accountsPanel.Padding.Bottom;

            accountsPanel.Height = totalHeight;
            int extraHeight = this.Height - this.ClientSize.Height;
            this.Height = accountsPanel.Bottom + 5 + extraHeight;
        }

        private void CodeControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _clickedCodeControl = sender as CodeTemplate;
                codeContextStrip.Show(Cursor.Position);
            }
        }

        private void AttachRightClickHandler(Control ctrl, MouseEventHandler handler)
        {
            ctrl.MouseUp += handler;

            foreach (Control child in ctrl.Controls)
            {
                AttachRightClickHandler(child, handler);
            }
        }

        private void CodeWindow_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FormLocation == new Point(0, 0))
            {
                // Let Windows decide where it should be at first
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Properties.Settings.Default.FormLocation;
            }
        }

        private void CodeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormLocation = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}