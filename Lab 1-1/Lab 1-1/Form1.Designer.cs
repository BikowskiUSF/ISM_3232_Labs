﻿namespace Lab_1_1
{
    partial class Form1
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.greetingButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(54, 82);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(310, 100);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter your first name in the box below and then click on the Greeting button.";
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(137, 155);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(126, 27);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // greetingButton
            // 
            this.greetingButton.Location = new System.Drawing.Point(155, 211);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(93, 33);
            this.greetingButton.TabIndex = 2;
            this.greetingButton.Text = "Greeting";
            this.greetingButton.UseVisualStyleBackColor = true;
            this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(155, 267);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(93, 31);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 398);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.greetingButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "First Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.Button quitButton;
    }
}

