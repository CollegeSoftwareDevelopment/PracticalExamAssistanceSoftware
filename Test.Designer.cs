namespace PracticalExamAssistanceSoftware
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.serverUrlLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(121, 192);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(255, 20);
            this.serverPortBox.TabIndex = 8;
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Location = new System.Drawing.Point(47, 195);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(20, 13);
            this.serverPortLabel.TabIndex = 7;
            this.serverPortLabel.Text = "roll";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(121, 135);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(255, 20);
            this.namebox.TabIndex = 6;
            // 
            // serverUrlLabel
            // 
            this.serverUrlLabel.AutoSize = true;
            this.serverUrlLabel.Location = new System.Drawing.Point(47, 138);
            this.serverUrlLabel.Name = "serverUrlLabel";
            this.serverUrlLabel.Size = new System.Drawing.Size(33, 13);
            this.serverUrlLabel.TabIndex = 5;
            this.serverUrlLabel.Text = "name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "branch";
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(518, 205);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 11;
            this.postButton.Text = "POST";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click_1);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverPortBox);
            this.Controls.Add(this.serverPortLabel);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.serverUrlLabel);
            this.Controls.Add(this.button1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.Label serverPortLabel;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label serverUrlLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button postButton;
    }
}