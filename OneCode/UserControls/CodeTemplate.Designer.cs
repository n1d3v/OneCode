
namespace OneCode.UserControls
{
    partial class CodeTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeName = new System.Windows.Forms.Label();
            this.codeDigits = new System.Windows.Forms.Label();
            this.codeTimeout = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // codeName
            // 
            this.codeName.AutoSize = true;
            this.codeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(158)))));
            this.codeName.Location = new System.Drawing.Point(-5, -6);
            this.codeName.Name = "codeName";
            this.codeName.Size = new System.Drawing.Size(85, 21);
            this.codeName.TabIndex = 0;
            this.codeName.Text = "codeName";
            // 
            // codeDigits
            // 
            this.codeDigits.AutoSize = true;
            this.codeDigits.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeDigits.Location = new System.Drawing.Point(-9, 15);
            this.codeDigits.Name = "codeDigits";
            this.codeDigits.Size = new System.Drawing.Size(122, 45);
            this.codeDigits.TabIndex = 1;
            this.codeDigits.Text = "000000";
            // 
            // codeTimeout
            // 
            this.codeTimeout.Location = new System.Drawing.Point(0, 60);
            this.codeTimeout.Name = "codeTimeout";
            this.codeTimeout.Size = new System.Drawing.Size(270, 23);
            this.codeTimeout.TabIndex = 2;
            // 
            // CodeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codeTimeout);
            this.Controls.Add(this.codeDigits);
            this.Controls.Add(this.codeName);
            this.Name = "CodeTemplate";
            this.Size = new System.Drawing.Size(270, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeName;
        private System.Windows.Forms.Label codeDigits;
        private System.Windows.Forms.ProgressBar codeTimeout;
    }
}
