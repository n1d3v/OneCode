using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OneCode.Classes;
using System.IO;

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
                MessageBox.Show("You have not entered any data into the box, enter some data and then continue.", "OneCode", MessageBoxButtons.OK);
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
    }
}
