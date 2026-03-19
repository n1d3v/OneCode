using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace OneCode
{
    public partial class AboutOneCode : Form
    {
        public AboutOneCode()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ko-fi.com/patrickpbt",
                UseShellExecute = true
            });
        }
    }
}