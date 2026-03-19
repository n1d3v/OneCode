using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using OneCode.Classes;
using System.IO;
using ZXing;

namespace OneCode
{
    public partial class ImportCode : Form
    {
        public ImportCode()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string otpData = dataImportBox.Text;

            if (string.IsNullOrEmpty(otpData))
            {
                MessageBox.Show("You have not entered any data into the box, enter some data and then continue.", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (googleAuthButton.Checked)
            {
                List<OtpResult> results = DecryptProtoOTP.ParseOTPString(otpData);
                List<AccountData> accounts = new List<AccountData>();

                foreach (var result in results)
                {
                    accounts.Add(new AccountData
                    {
                        Issuer = result.Issuer,
                        Secret = result.Secret,
                        Name = result.Name
                    });
                }

                string xmlData = DataParser.CreateXml(accounts);
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OneCodeAccs.xml");
                File.WriteAllText(filePath, xmlData);
            }
            else
            {
                // Do nothing.
            }
        }

        private void importManuallyButton_Click(object sender, EventArgs e)
        {
            string otpData = codeSecretBox.Text;

            if (string.IsNullOrEmpty(otpData))
            {
                MessageBox.Show("You have not entered any data into the secret box, enter some secret and then continue.", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OneCodeAccs.xml" );

            List<AccountData> accounts;
            if (File.Exists(filePath))
            {
                string existingXml = File.ReadAllText(filePath);
                accounts = DataParser.ParseXml(existingXml);
            } else { accounts = new List<AccountData>(); }

            accounts.Add(new AccountData
            {
                Issuer = codeIssuerBox.Text,
                Secret = codeSecretBox.Text,
                Name = codeNameBox.Text
            });

            string xmlData = DataParser.CreateXml(accounts);
            File.WriteAllText(filePath, xmlData);
        }

        private void scanQrButton_Click(object sender, EventArgs e)
        {
            Bitmap screenshot = CaptureScreen();

            var reader = new BarcodeReader();
            var result = reader.Decode(screenshot);

            if (result != null)
            {
                dataImportBox.Text = result.Text;
                MessageBox.Show("QR code detected and imported successfully! Please restart the application to view the code.", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No QR code was found on the screen, please put it in view and try scanning the QR code again.", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Bitmap CaptureScreen()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);

            return bitmap;
        }
    }
}