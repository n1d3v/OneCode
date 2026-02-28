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
        private int lastSecond = -1; // track step change

        public CodeTemplate()
        {
            InitializeComponent();
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
            timer.Interval = 50; // 20 updates per second for smooth bar
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

            int smoothMax = 3000;
            codeTimeout.Maximum = smoothMax;
            codeTimeout.Value = Math.Max(0, Math.Min(smoothMax, (int)((secondsLeft / stepDuration) * smoothMax)));

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