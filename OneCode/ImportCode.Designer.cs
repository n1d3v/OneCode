
namespace OneCode
{
    partial class ImportCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportCode));
            this.impLabel = new System.Windows.Forms.Label();
            this.impDesc = new System.Windows.Forms.Label();
            this.googleAuthButton = new System.Windows.Forms.RadioButton();
            this.importButton = new System.Windows.Forms.Button();
            this.dataImportBox = new System.Windows.Forms.TextBox();
            this.impManLabel = new System.Windows.Forms.Label();
            this.impManDesc = new System.Windows.Forms.Label();
            this.importManuallyButton = new System.Windows.Forms.Button();
            this.codeIssuerLabel = new System.Windows.Forms.Label();
            this.codeIssuerBox = new System.Windows.Forms.TextBox();
            this.codeNameBox = new System.Windows.Forms.TextBox();
            this.codeNameLabel = new System.Windows.Forms.Label();
            this.codeSecretBox = new System.Windows.Forms.TextBox();
            this.codeSecretLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // impLabel
            // 
            this.impLabel.AutoSize = true;
            this.impLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(158)))));
            this.impLabel.Location = new System.Drawing.Point(16, 13);
            this.impLabel.Name = "impLabel";
            this.impLabel.Size = new System.Drawing.Size(233, 21);
            this.impLabel.TabIndex = 1;
            this.impLabel.Text = "Import your authenticator codes";
            // 
            // impDesc
            // 
            this.impDesc.AutoSize = true;
            this.impDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impDesc.Location = new System.Drawing.Point(17, 36);
            this.impDesc.Name = "impDesc";
            this.impDesc.Size = new System.Drawing.Size(241, 15);
            this.impDesc.TabIndex = 2;
            this.impDesc.Text = "You can import your codes from other apps.";
            // 
            // googleAuthButton
            // 
            this.googleAuthButton.AutoSize = true;
            this.googleAuthButton.Checked = true;
            this.googleAuthButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleAuthButton.Location = new System.Drawing.Point(20, 57);
            this.googleAuthButton.Name = "googleAuthButton";
            this.googleAuthButton.Size = new System.Drawing.Size(139, 19);
            this.googleAuthButton.TabIndex = 3;
            this.googleAuthButton.TabStop = true;
            this.googleAuthButton.Text = "Google Authenticator";
            this.googleAuthButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(170, 114);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(124, 23);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Import my codes!";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // dataImportBox
            // 
            this.dataImportBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataImportBox.Location = new System.Drawing.Point(20, 82);
            this.dataImportBox.Name = "dataImportBox";
            this.dataImportBox.Size = new System.Drawing.Size(274, 23);
            this.dataImportBox.TabIndex = 5;
            // 
            // impManLabel
            // 
            this.impManLabel.AutoSize = true;
            this.impManLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impManLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(158)))));
            this.impManLabel.Location = new System.Drawing.Point(16, 146);
            this.impManLabel.Name = "impManLabel";
            this.impManLabel.Size = new System.Drawing.Size(174, 21);
            this.impManLabel.TabIndex = 6;
            this.impManLabel.Text = "Import a code manually";
            // 
            // impManDesc
            // 
            this.impManDesc.AutoSize = true;
            this.impManDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impManDesc.Location = new System.Drawing.Point(17, 169);
            this.impManDesc.Name = "impManDesc";
            this.impManDesc.Size = new System.Drawing.Size(202, 15);
            this.impManDesc.TabIndex = 7;
            this.impManDesc.Text = "You can also manually enter a secret.";
            // 
            // importManuallyButton
            // 
            this.importManuallyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importManuallyButton.Location = new System.Drawing.Point(170, 281);
            this.importManuallyButton.Name = "importManuallyButton";
            this.importManuallyButton.Size = new System.Drawing.Size(124, 23);
            this.importManuallyButton.TabIndex = 8;
            this.importManuallyButton.Text = "Import manually!";
            this.importManuallyButton.UseVisualStyleBackColor = true;
            this.importManuallyButton.Click += new System.EventHandler(this.importManuallyButton_Click);
            // 
            // codeIssuerLabel
            // 
            this.codeIssuerLabel.AutoSize = true;
            this.codeIssuerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeIssuerLabel.Location = new System.Drawing.Point(17, 194);
            this.codeIssuerLabel.Name = "codeIssuerLabel";
            this.codeIssuerLabel.Size = new System.Drawing.Size(68, 15);
            this.codeIssuerLabel.TabIndex = 9;
            this.codeIssuerLabel.Text = "Code issuer";
            // 
            // codeIssuerBox
            // 
            this.codeIssuerBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeIssuerBox.Location = new System.Drawing.Point(91, 191);
            this.codeIssuerBox.Name = "codeIssuerBox";
            this.codeIssuerBox.Size = new System.Drawing.Size(201, 23);
            this.codeIssuerBox.TabIndex = 10;
            // 
            // codeNameBox
            // 
            this.codeNameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeNameBox.Location = new System.Drawing.Point(91, 220);
            this.codeNameBox.Name = "codeNameBox";
            this.codeNameBox.Size = new System.Drawing.Size(201, 23);
            this.codeNameBox.TabIndex = 12;
            // 
            // codeNameLabel
            // 
            this.codeNameLabel.AutoSize = true;
            this.codeNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeNameLabel.Location = new System.Drawing.Point(18, 223);
            this.codeNameLabel.Name = "codeNameLabel";
            this.codeNameLabel.Size = new System.Drawing.Size(68, 15);
            this.codeNameLabel.TabIndex = 11;
            this.codeNameLabel.Text = "Code name";
            // 
            // codeSecretBox
            // 
            this.codeSecretBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeSecretBox.Location = new System.Drawing.Point(91, 249);
            this.codeSecretBox.Name = "codeSecretBox";
            this.codeSecretBox.Size = new System.Drawing.Size(201, 23);
            this.codeSecretBox.TabIndex = 14;
            this.codeSecretBox.UseSystemPasswordChar = true;
            // 
            // codeSecretLabel
            // 
            this.codeSecretLabel.AutoSize = true;
            this.codeSecretLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeSecretLabel.Location = new System.Drawing.Point(17, 252);
            this.codeSecretLabel.Name = "codeSecretLabel";
            this.codeSecretLabel.Size = new System.Drawing.Size(69, 15);
            this.codeSecretLabel.TabIndex = 13;
            this.codeSecretLabel.Text = "Code secret";
            // 
            // ImportCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 316);
            this.Controls.Add(this.codeSecretBox);
            this.Controls.Add(this.codeSecretLabel);
            this.Controls.Add(this.codeNameBox);
            this.Controls.Add(this.codeNameLabel);
            this.Controls.Add(this.codeIssuerBox);
            this.Controls.Add(this.codeIssuerLabel);
            this.Controls.Add(this.importManuallyButton);
            this.Controls.Add(this.impManDesc);
            this.Controls.Add(this.impManLabel);
            this.Controls.Add(this.dataImportBox);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.googleAuthButton);
            this.Controls.Add(this.impDesc);
            this.Controls.Add(this.impLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import your codes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label impLabel;
        private System.Windows.Forms.Label impDesc;
        private System.Windows.Forms.RadioButton googleAuthButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.TextBox dataImportBox;
        private System.Windows.Forms.Label impManLabel;
        private System.Windows.Forms.Label impManDesc;
        private System.Windows.Forms.Button importManuallyButton;
        private System.Windows.Forms.Label codeIssuerLabel;
        private System.Windows.Forms.TextBox codeIssuerBox;
        private System.Windows.Forms.TextBox codeNameBox;
        private System.Windows.Forms.Label codeNameLabel;
        private System.Windows.Forms.TextBox codeSecretBox;
        private System.Windows.Forms.Label codeSecretLabel;
    }
}