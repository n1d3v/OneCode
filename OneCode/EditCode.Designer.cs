
namespace OneCode
{
    partial class EditCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCode));
            this.codeIssuerLabel = new System.Windows.Forms.Label();
            this.codeNameLabel = new System.Windows.Forms.Label();
            this.codeSecretLabel = new System.Windows.Forms.Label();
            this.codeSecretBox = new System.Windows.Forms.TextBox();
            this.codeNameBox = new System.Windows.Forms.TextBox();
            this.codeIssuerBox = new System.Windows.Forms.TextBox();
            this.editHeader = new System.Windows.Forms.Label();
            this.editHelp = new System.Windows.Forms.Label();
            this.saveCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeIssuerLabel
            // 
            this.codeIssuerLabel.AutoSize = true;
            this.codeIssuerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeIssuerLabel.Location = new System.Drawing.Point(19, 64);
            this.codeIssuerLabel.Name = "codeIssuerLabel";
            this.codeIssuerLabel.Size = new System.Drawing.Size(68, 15);
            this.codeIssuerLabel.TabIndex = 0;
            this.codeIssuerLabel.Text = "Code issuer";
            // 
            // codeNameLabel
            // 
            this.codeNameLabel.AutoSize = true;
            this.codeNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeNameLabel.Location = new System.Drawing.Point(19, 99);
            this.codeNameLabel.Name = "codeNameLabel";
            this.codeNameLabel.Size = new System.Drawing.Size(68, 15);
            this.codeNameLabel.TabIndex = 1;
            this.codeNameLabel.Text = "Code name";
            // 
            // codeSecretLabel
            // 
            this.codeSecretLabel.AutoSize = true;
            this.codeSecretLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeSecretLabel.Location = new System.Drawing.Point(18, 134);
            this.codeSecretLabel.Name = "codeSecretLabel";
            this.codeSecretLabel.Size = new System.Drawing.Size(69, 15);
            this.codeSecretLabel.TabIndex = 2;
            this.codeSecretLabel.Text = "Code secret";
            // 
            // codeSecretBox
            // 
            this.codeSecretBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeSecretBox.Location = new System.Drawing.Point(93, 131);
            this.codeSecretBox.Name = "codeSecretBox";
            this.codeSecretBox.Size = new System.Drawing.Size(459, 23);
            this.codeSecretBox.TabIndex = 3;
            // 
            // codeNameBox
            // 
            this.codeNameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeNameBox.Location = new System.Drawing.Point(93, 96);
            this.codeNameBox.Name = "codeNameBox";
            this.codeNameBox.Size = new System.Drawing.Size(459, 23);
            this.codeNameBox.TabIndex = 4;
            // 
            // codeIssuerBox
            // 
            this.codeIssuerBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeIssuerBox.Location = new System.Drawing.Point(93, 61);
            this.codeIssuerBox.Name = "codeIssuerBox";
            this.codeIssuerBox.Size = new System.Drawing.Size(459, 23);
            this.codeIssuerBox.TabIndex = 5;
            // 
            // editHeader
            // 
            this.editHeader.AutoSize = true;
            this.editHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(156)))));
            this.editHeader.Location = new System.Drawing.Point(17, 11);
            this.editHeader.Name = "editHeader";
            this.editHeader.Size = new System.Drawing.Size(202, 21);
            this.editHeader.TabIndex = 6;
            this.editHeader.Text = "Edit \"<CODE_XML>\" details";
            // 
            // editHelp
            // 
            this.editHelp.AutoSize = true;
            this.editHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editHelp.Location = new System.Drawing.Point(18, 34);
            this.editHelp.Name = "editHelp";
            this.editHelp.Size = new System.Drawing.Size(398, 15);
            this.editHelp.TabIndex = 7;
            this.editHelp.Text = "You may also edit the details of your codes in the \"OneCodeAccs.xml\" file.";
            // 
            // saveCodeButton
            // 
            this.saveCodeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCodeButton.Location = new System.Drawing.Point(468, 162);
            this.saveCodeButton.Name = "saveCodeButton";
            this.saveCodeButton.Size = new System.Drawing.Size(84, 23);
            this.saveCodeButton.TabIndex = 8;
            this.saveCodeButton.Text = "Save code";
            this.saveCodeButton.UseVisualStyleBackColor = true;
            // 
            // EditCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 194);
            this.Controls.Add(this.saveCodeButton);
            this.Controls.Add(this.editHelp);
            this.Controls.Add(this.editHeader);
            this.Controls.Add(this.codeIssuerBox);
            this.Controls.Add(this.codeNameBox);
            this.Controls.Add(this.codeSecretBox);
            this.Controls.Add(this.codeSecretLabel);
            this.Controls.Add(this.codeNameLabel);
            this.Controls.Add(this.codeIssuerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCode";
            this.Text = "Edit code details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeIssuerLabel;
        private System.Windows.Forms.Label codeNameLabel;
        private System.Windows.Forms.Label codeSecretLabel;
        private System.Windows.Forms.TextBox codeSecretBox;
        private System.Windows.Forms.TextBox codeNameBox;
        private System.Windows.Forms.TextBox codeIssuerBox;
        private System.Windows.Forms.Label editHeader;
        private System.Windows.Forms.Label editHelp;
        private System.Windows.Forms.Button saveCodeButton;
    }
}