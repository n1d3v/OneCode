using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
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

            if (result == null)
            {
                MessageBox.Show("No QR code was found on the screen, please put it in view and try scanning the QR code again.", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string otpUri = result.Text;

            try
            {
                var uri = new Uri(otpUri);
                string type = uri.Host;

                string label = Uri.UnescapeDataString(uri.AbsolutePath.TrimStart('/'));
                string issuerLabel = "";
                string accountName = "";

                if (label.Contains(":"))
                {
                    var parts = label.Split(':');
                    issuerLabel = parts[0];
                    accountName = parts[1];
                }
                else { accountName = label; }

                // Query parser for reading the OTP URLs
                var queryParams = uri.Query.TrimStart('?')
                    .Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Split('='))
                    .ToDictionary(
                        p => Uri.UnescapeDataString(p[0]),
                        p => p.Length > 1 ? Uri.UnescapeDataString(p[1]) : ""
                    );

                string issuer = queryParams.ContainsKey("issuer") ? queryParams["issuer"] : null;
                string secret = queryParams.ContainsKey("secret") ? queryParams["secret"] : null;

                if (string.IsNullOrEmpty(secret))
                    throw new Exception("Invalid QR: missing secret");

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OneCodeAccs.xml");

                List<AccountData> accounts;
                if (File.Exists(filePath))
                {
                    string existingXml = File.ReadAllText(filePath);
                    accounts = DataParser.ParseXml(existingXml);
                }
                else { accounts = new List<AccountData>(); }

                accounts.Add(new AccountData
                {
                    Issuer = issuer,
                    Secret = secret,
                    Name = accountName
                });

                // Write the new OTP code data into the XML file
                string xmlData = DataParser.CreateXml(accounts);
                File.WriteAllText(filePath, xmlData);

                MessageBox.Show("QR code imported successfully! Please restart the application to view the code.", "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to parse QR code: " + ex.Message, "OneCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
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