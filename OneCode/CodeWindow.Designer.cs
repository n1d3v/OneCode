
namespace OneCode
{
    partial class CodeWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeWindow));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importCodesButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accountsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.codeContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyCodeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCodeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCodeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCodeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(158)))));
            this.welcomeLabel.Location = new System.Drawing.Point(16, 13);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(167, 21);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to OneCode!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "You have <NUMBER_OF_CODES> codes available.";
            // 
            // importCodesButton
            // 
            this.importCodesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.importCodesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCodesButton.Location = new System.Drawing.Point(230, 421);
            this.importCodesButton.Name = "importCodesButton";
            this.importCodesButton.Size = new System.Drawing.Size(92, 23);
            this.importCodesButton.TabIndex = 2;
            this.importCodesButton.Text = "Import codes";
            this.importCodesButton.UseVisualStyleBackColor = true;
            this.importCodesButton.Click += new System.EventHandler(this.importCodesButton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export codes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // accountsPanel
            // 
            this.accountsPanel.AutoScroll = true;
            this.accountsPanel.Location = new System.Drawing.Point(18, 61);
            this.accountsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.accountsPanel.Size = new System.Drawing.Size(304, 347);
            this.accountsPanel.TabIndex = 4;
            // 
            // codeContextStrip
            // 
            this.codeContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCodeItem,
            this.refreshCodeItem,
            this.itemSeparator,
            this.removeCodeItem,
            this.modifyCodeItem});
            this.codeContextStrip.Name = "codeContextStrip";
            this.codeContextStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.codeContextStrip.Size = new System.Drawing.Size(181, 120);
            // 
            // itemSeparator
            // 
            this.itemSeparator.Name = "itemSeparator";
            this.itemSeparator.Size = new System.Drawing.Size(175, 6);
            // 
            // copyCodeItem
            // 
            this.copyCodeItem.Image = global::OneCode.Properties.Resources.Clipboard;
            this.copyCodeItem.Name = "copyCodeItem";
            this.copyCodeItem.Size = new System.Drawing.Size(178, 22);
            this.copyCodeItem.Text = "Copy code";
            // 
            // refreshCodeItem
            // 
            this.refreshCodeItem.Image = global::OneCode.Properties.Resources.Refresh;
            this.refreshCodeItem.Name = "refreshCodeItem";
            this.refreshCodeItem.Size = new System.Drawing.Size(178, 22);
            this.refreshCodeItem.Text = "Refresh code";
            // 
            // removeCodeItem
            // 
            this.removeCodeItem.Image = global::OneCode.Properties.Resources.Remove;
            this.removeCodeItem.Name = "removeCodeItem";
            this.removeCodeItem.Size = new System.Drawing.Size(178, 22);
            this.removeCodeItem.Text = "Remove this code";
            // 
            // modifyCodeItem
            // 
            this.modifyCodeItem.Image = global::OneCode.Properties.Resources.Modify;
            this.modifyCodeItem.Name = "modifyCodeItem";
            this.modifyCodeItem.Size = new System.Drawing.Size(180, 22);
            this.modifyCodeItem.Text = "Modify code details";
            // 
            // CodeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 456);
            this.Controls.Add(this.accountsPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.importCodesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneCode";
            this.codeContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importCodesButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel accountsPanel;
        private System.Windows.Forms.ContextMenuStrip codeContextStrip;
        private System.Windows.Forms.ToolStripMenuItem copyCodeItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCodeItem;
        private System.Windows.Forms.ToolStripSeparator itemSeparator;
        private System.Windows.Forms.ToolStripMenuItem refreshCodeItem;
        private System.Windows.Forms.ToolStripMenuItem removeCodeItem;
    }
}

