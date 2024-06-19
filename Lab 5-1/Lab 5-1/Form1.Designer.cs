namespace Lab_5_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.icreCreamPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sugarConeRadioButton = new System.Windows.Forms.RadioButton();
            this.waffleConeRadioButton = new System.Windows.Forms.RadioButton();
            this.iceCreamListBox = new System.Windows.Forms.Label();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.flavorComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icreCreamPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // icreCreamPictureBox
            // 
            this.icreCreamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("icreCreamPictureBox.Image")));
            this.icreCreamPictureBox.Location = new System.Drawing.Point(45, 12);
            this.icreCreamPictureBox.Name = "icreCreamPictureBox";
            this.icreCreamPictureBox.Size = new System.Drawing.Size(346, 234);
            this.icreCreamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icreCreamPictureBox.TabIndex = 0;
            this.icreCreamPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cone Type:";
            // 
            // sugarConeRadioButton
            // 
            this.sugarConeRadioButton.AutoSize = true;
            this.sugarConeRadioButton.Checked = true;
            this.sugarConeRadioButton.Location = new System.Drawing.Point(147, 280);
            this.sugarConeRadioButton.Name = "sugarConeRadioButton";
            this.sugarConeRadioButton.Size = new System.Drawing.Size(122, 24);
            this.sugarConeRadioButton.TabIndex = 2;
            this.sugarConeRadioButton.TabStop = true;
            this.sugarConeRadioButton.Text = "Sugar Cone";
            this.sugarConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // waffleConeRadioButton
            // 
            this.waffleConeRadioButton.AutoSize = true;
            this.waffleConeRadioButton.Location = new System.Drawing.Point(275, 280);
            this.waffleConeRadioButton.Name = "waffleConeRadioButton";
            this.waffleConeRadioButton.Size = new System.Drawing.Size(126, 24);
            this.waffleConeRadioButton.TabIndex = 3;
            this.waffleConeRadioButton.TabStop = true;
            this.waffleConeRadioButton.Text = "Waffle Cone";
            this.waffleConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // iceCreamListBox
            // 
            this.iceCreamListBox.AutoSize = true;
            this.iceCreamListBox.Location = new System.Drawing.Point(41, 338);
            this.iceCreamListBox.Name = "iceCreamListBox";
            this.iceCreamListBox.Size = new System.Drawing.Size(142, 20);
            this.iceCreamListBox.TabIndex = 4;
            this.iceCreamListBox.Text = "Ice Cream Flavor:";
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.ItemHeight = 20;
            this.toppingsListBox.Items.AddRange(new object[] {
            "Chopped Nuts",
            "Chocolate Chips",
            "Marshmallows",
            "Candy Sprinkles",
            "Cinnamon Dots",
            "Gummy Stars"});
            this.toppingsListBox.Location = new System.Drawing.Point(204, 391);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toppingsListBox.Size = new System.Drawing.Size(159, 124);
            this.toppingsListBox.TabIndex = 5;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(101, 391);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(82, 20);
            this.toppingsLabel.TabIndex = 6;
            this.toppingsLabel.Text = "Toppings:";
            // 
            // flavorComboBox
            // 
            this.flavorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flavorComboBox.FormattingEnabled = true;
            this.flavorComboBox.Location = new System.Drawing.Point(204, 335);
            this.flavorComboBox.Name = "flavorComboBox";
            this.flavorComboBox.Size = new System.Drawing.Size(159, 28);
            this.flavorComboBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(76, 544);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 32);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(244, 544);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 32);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "7";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 606);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.flavorComboBox);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.toppingsListBox);
            this.Controls.Add(this.iceCreamListBox);
            this.Controls.Add(this.waffleConeRadioButton);
            this.Controls.Add(this.sugarConeRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icreCreamPictureBox);
            this.Name = "Form1";
            this.Text = "Joe\'s Ice Cream Emporium";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icreCreamPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icreCreamPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sugarConeRadioButton;
        private System.Windows.Forms.RadioButton waffleConeRadioButton;
        private System.Windows.Forms.Label iceCreamListBox;
        private System.Windows.Forms.ListBox toppingsListBox;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.ComboBox flavorComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}

