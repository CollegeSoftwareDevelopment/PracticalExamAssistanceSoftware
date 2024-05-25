namespace PracticalExamAssistanceSoftware
{
    partial class Login
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
            this.PEASLogoBox = new System.Windows.Forms.PictureBox();
            this.loginFormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PEASLogoBox)).BeginInit();
            this.loginFormContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PEASLogoBox
            // 
            this.PEASLogoBox.Image = global::PracticalExamAssistanceSoftware.Properties.Resources.PRACTICAL_EXAM_ASSISTANCE_SOFTWARE_LOGO;
            this.PEASLogoBox.Location = new System.Drawing.Point(12, 12);
            this.PEASLogoBox.Name = "PEASLogoBox";
            this.PEASLogoBox.Size = new System.Drawing.Size(500, 500);
            this.PEASLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PEASLogoBox.TabIndex = 0;
            this.PEASLogoBox.TabStop = false;
            // 
            // loginFormContextMenu
            // 
            this.loginFormContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.loginFormContextMenu.Name = "loginFormContextMenu";
            this.loginFormContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 547);
            this.Controls.Add(this.PEASLogoBox);
            this.Name = "Login";
            this.Text = "PEAS - Login";
            ((System.ComponentModel.ISupportInitialize)(this.PEASLogoBox)).EndInit();
            this.loginFormContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PEASLogoBox;
        private System.Windows.Forms.ContextMenuStrip loginFormContextMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

