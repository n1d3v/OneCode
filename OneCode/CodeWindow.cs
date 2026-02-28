using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneCode.UserControls;
using OneCode.Classes;
using System.IO;

namespace OneCode
{
    public partial class CodeWindow : Form
    {
        private CodeTemplate _clickedCodeControl;

        public CodeWindow()
        {
            InitializeComponent();
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            string xmlFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OneCodeAccs.xml");

            if (!File.Exists(xmlFile))
            {
                MessageBox.Show($"File not found: {xmlFile}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string xmlContent = File.ReadAllText(xmlFile, System.Text.Encoding.UTF8).Trim();
            List<AccountData> accounts = DataParser.ParseXml(xmlContent);

            accountsPanel.Controls.Clear();

            foreach (var acc in accounts)
            {
                var codeControl = new CodeTemplate();
                codeControl.SetAccount(acc.Name, acc.Secret, 6);

                AttachRightClickHandler(codeControl, CodeControl_MouseUp);
                accountsPanel.Controls.Add(codeControl);
            }
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

        private void importCodesButton_Click(object sender, EventArgs e)
        {
            ImportCode importForm = new ImportCode();
            importForm.ShowDialog();
        }
    }
}
