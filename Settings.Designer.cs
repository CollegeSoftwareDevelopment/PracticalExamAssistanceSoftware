namespace PracticalExamAssistanceSoftware
{
    partial class Settings
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
            this.serverUrlLabel = new System.Windows.Forms.Label();
            this.serverUrlBox = new System.Windows.Forms.TextBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverUrlLabel
            // 
            this.serverUrlLabel.AutoSize = true;
            this.serverUrlLabel.Location = new System.Drawing.Point(50, 81);
            this.serverUrlLabel.Name = "serverUrlLabel";
            this.serverUrlLabel.Size = new System.Drawing.Size(63, 13);
            this.serverUrlLabel.TabIndex = 0;
            this.serverUrlLabel.Text = "Server URL";
            // 
            // serverUrlBox
            // 
            this.serverUrlBox.Location = new System.Drawing.Point(124, 78);
            this.serverUrlBox.Name = "serverUrlBox";
            this.serverUrlBox.Size = new System.Drawing.Size(255, 20);
            this.serverUrlBox.TabIndex = 1;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(429, 76);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(114, 23);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(429, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(124, 135);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(255, 20);
            this.serverPortBox.TabIndex = 4;
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Location = new System.Drawing.Point(50, 138);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(63, 13);
            this.serverPortLabel.TabIndex = 3;
            this.serverPortLabel.Text = "Server Port ";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 277);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.serverPortBox);
            this.Controls.Add(this.serverPortLabel);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.serverUrlBox);
            this.Controls.Add(this.serverUrlLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverUrlLabel;
        private System.Windows.Forms.TextBox serverUrlBox;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.Label serverPortLabel;
    }
}