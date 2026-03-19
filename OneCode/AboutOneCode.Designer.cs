
namespace OneCode
{
    partial class AboutOneCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutOneCode));
            this.aboutHeader = new System.Windows.Forms.Label();
            this.aboutAuthor = new System.Windows.Forms.Label();
            this.aboutOneCodeDesc = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.donateButton = new System.Windows.Forms.Button();
            this.oneCodeIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.oneCodeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutHeader
            // 
            this.aboutHeader.AutoSize = true;
            this.aboutHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(158)))));
            this.aboutHeader.Location = new System.Drawing.Point(49, 9);
            this.aboutHeader.Name = "aboutHeader";
            this.aboutHeader.Size = new System.Drawing.Size(75, 21);
            this.aboutHeader.TabIndex = 1;
            this.aboutHeader.Text = "OneCode";
            // 
            // aboutAuthor
            // 
            this.aboutAuthor.AutoSize = true;
            this.aboutAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutAuthor.Location = new System.Drawing.Point(50, 30);
            this.aboutAuthor.Name = "aboutAuthor";
            this.aboutAuthor.Size = new System.Drawing.Size(134, 15);
            this.aboutAuthor.TabIndex = 2;
            this.aboutAuthor.Text = "Produced by patricktbp!";
            // 
            // aboutOneCodeDesc
            // 
            this.aboutOneCodeDesc.AutoSize = true;
            this.aboutOneCodeDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutOneCodeDesc.Location = new System.Drawing.Point(12, 52);
            this.aboutOneCodeDesc.Name = "aboutOneCodeDesc";
            this.aboutOneCodeDesc.Size = new System.Drawing.Size(277, 45);
            this.aboutOneCodeDesc.TabIndex = 3;
            this.aboutOneCodeDesc.Text = "OneCode is a native-styled Windows application\r\nallowing the generation of OTP co" +
    "des on your\r\ncomputer without the necessity of a mobile device.";
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(238, 107);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // donateButton
            // 
            this.donateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.donateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateButton.Location = new System.Drawing.Point(15, 107);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(66, 23);
            this.donateButton.TabIndex = 5;
            this.donateButton.Text = "Donate!";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // oneCodeIcon
            // 
            this.oneCodeIcon.Image = global::OneCode.Properties.Resources.OneCode;
            this.oneCodeIcon.Location = new System.Drawing.Point(12, 12);
            this.oneCodeIcon.Name = "oneCodeIcon";
            this.oneCodeIcon.Size = new System.Drawing.Size(32, 32);
            this.oneCodeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oneCodeIcon.TabIndex = 0;
            this.oneCodeIcon.TabStop = false;
            // 
            // AboutOneCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 147);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutOneCodeDesc);
            this.Controls.Add(this.aboutAuthor);
            this.Controls.Add(this.aboutHeader);
            this.Controls.Add(this.oneCodeIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutOneCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About OneCode";
            ((System.ComponentModel.ISupportInitialize)(this.oneCodeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox oneCodeIcon;
        private System.Windows.Forms.Label aboutHeader;
        private System.Windows.Forms.Label aboutAuthor;
        private System.Windows.Forms.Label aboutOneCodeDesc;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button donateButton;
    }
}