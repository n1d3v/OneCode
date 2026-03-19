
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
            this.SuspendLayout();
            // 
            // codeName
            // 
            this.codeName.AutoSize = true;
            this.codeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(158)))));
            this.codeName.Location = new System.Drawing.Point(-4, 5);
            this.codeName.Name = "codeName";
            this.codeName.Size = new System.Drawing.Size(65, 15);
            this.codeName.TabIndex = 0;
            this.codeName.Text = "codeName";
            // 
            // codeDigits
            // 
            this.codeDigits.AutoSize = true;
            this.codeDigits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeDigits.Location = new System.Drawing.Point(203, 5);
            this.codeDigits.Name = "codeDigits";
            this.codeDigits.Size = new System.Drawing.Size(46, 15);
            this.codeDigits.TabIndex = 1;
            this.codeDigits.Text = "000 000";
            this.codeDigits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CodeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codeDigits);
            this.Controls.Add(this.codeName);
            this.Name = "CodeTemplate";
            this.Size = new System.Drawing.Size(270, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeName;
        private System.Windows.Forms.Label codeDigits;
    }
}
