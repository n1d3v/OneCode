using System;
using System.Windows.Forms;
using OneCode.Classes;

namespace OneCode.UserControls
{
    public partial class CodeTemplate : UserControl
    {
        private Timer timer;
        private string baseSecret;
        private int digitAmount;
        private int lastSecond = -1;

        private LoadingThrobber codeTimeout;

        public CodeTemplate()
        {
            InitializeComponent();
            
            // Add our custom pie-like throbber, inspired by Google Authenticator
            codeTimeout = new LoadingThrobber();
            codeTimeout.Size = new System.Drawing.Size(19, 19);
            codeTimeout.Location = new System.Drawing.Point(251, 3);
            Controls.Add(codeTimeout);

            InitializeTimer();
        }

        public void SetAccount(string accountName, string secret, int totpDigits = 6)
        {
            codeName.Text = accountName;
            baseSecret = secret;
            digitAmount = totpDigits;
            UpdateCode();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += (s, e) => UpdateCode();
            timer.Start();
        }

        public void UpdateCode()
        {
            if (string.IsNullOrEmpty(baseSecret)) return;

            double unixTime = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            double stepDuration = 30.0;
            double secondsIntoStep = unixTime % stepDuration;
            double secondsLeft = stepDuration - secondsIntoStep;

            codeTimeout.SetProgress(secondsLeft / stepDuration);

            int currentSecond = (int)secondsLeft;
            if (currentSecond != lastSecond)
            {
                lastSecond = currentSecond;
                byte[] secretBytes = Base32.FromBase32(baseSecret);
                codeDigits.Text = GenerateCode.GenerateTOTP(secretBytes, digitAmount, 1);
            }
        }
    }
}