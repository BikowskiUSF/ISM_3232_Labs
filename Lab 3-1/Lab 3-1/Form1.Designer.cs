namespace Lab_3_1
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
            this.petOwnerGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.ownerPhoneLabel = new System.Windows.Forms.Label();
            this.petGroupBox = new System.Windows.Forms.GroupBox();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.catRadioButton = new System.Windows.Forms.RadioButton();
            this.typeIfOtherLabel = new System.Windows.Forms.Label();
            this.typeIfOtherTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petDOBMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petDateOfBirthLabel = new System.Windows.Forms.Label();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.furTrimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.nailClippingCheckBox = new System.Windows.Forms.CheckBox();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.fleaRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.totalFeeLabelText = new System.Windows.Forms.Label();
            this.furTrimmingPriceLabel = new System.Windows.Forms.Label();
            this.shampooPriceLabel = new System.Windows.Forms.Label();
            this.nailClippingPriceLabel = new System.Windows.Forms.Label();
            this.fleaRemovalPriceLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.petOwnerGroupBox.SuspendLayout();
            this.petGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // petOwnerGroupBox
            // 
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneMaskedTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameLabel);
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneLabel);
            this.petOwnerGroupBox.Location = new System.Drawing.Point(12, 24);
            this.petOwnerGroupBox.Name = "petOwnerGroupBox";
            this.petOwnerGroupBox.Size = new System.Drawing.Size(586, 135);
            this.petOwnerGroupBox.TabIndex = 0;
            this.petOwnerGroupBox.TabStop = false;
            this.petOwnerGroupBox.Text = "Pet Owner";
            // 
            // ownerPhoneMaskedTextBox
            // 
            this.ownerPhoneMaskedTextBox.Location = new System.Drawing.Point(174, 81);
            this.ownerPhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.ownerPhoneMaskedTextBox.Name = "ownerPhoneMaskedTextBox";
            this.ownerPhoneMaskedTextBox.Size = new System.Drawing.Size(128, 27);
            this.ownerPhoneMaskedTextBox.TabIndex = 2;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(174, 39);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(194, 27);
            this.ownerNameTextBox.TabIndex = 1;
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(45, 39);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(112, 20);
            this.ownerNameLabel.TabIndex = 6;
            this.ownerNameLabel.Text = "&Owner Name:";
            // 
            // ownerPhoneLabel
            // 
            this.ownerPhoneLabel.AutoSize = true;
            this.ownerPhoneLabel.Location = new System.Drawing.Point(42, 81);
            this.ownerPhoneLabel.Name = "ownerPhoneLabel";
            this.ownerPhoneLabel.Size = new System.Drawing.Size(115, 20);
            this.ownerPhoneLabel.TabIndex = 7;
            this.ownerPhoneLabel.Text = "O&wner Phone:";
            // 
            // petGroupBox
            // 
            this.petGroupBox.Controls.Add(this.otherRadioButton);
            this.petGroupBox.Controls.Add(this.dogRadioButton);
            this.petGroupBox.Controls.Add(this.catRadioButton);
            this.petGroupBox.Controls.Add(this.typeIfOtherLabel);
            this.petGroupBox.Controls.Add(this.typeIfOtherTextBox);
            this.petGroupBox.Controls.Add(this.petNameTextBox);
            this.petGroupBox.Controls.Add(this.petDOBMaskedTextBox);
            this.petGroupBox.Controls.Add(this.petTypeLabel);
            this.petGroupBox.Controls.Add(this.petNameLabel);
            this.petGroupBox.Controls.Add(this.petDateOfBirthLabel);
            this.petGroupBox.Location = new System.Drawing.Point(12, 185);
            this.petGroupBox.Name = "petGroupBox";
            this.petGroupBox.Size = new System.Drawing.Size(586, 215);
            this.petGroupBox.TabIndex = 0;
            this.petGroupBox.TabStop = false;
            this.petGroupBox.Text = "Pet";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(369, 130);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(76, 24);
            this.otherRadioButton.TabIndex = 7;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.AutoSize = true;
            this.dogRadioButton.Location = new System.Drawing.Point(273, 130);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(65, 24);
            this.dogRadioButton.TabIndex = 6;
            this.dogRadioButton.TabStop = true;
            this.dogRadioButton.Text = "Dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // catRadioButton
            // 
            this.catRadioButton.AutoSize = true;
            this.catRadioButton.Location = new System.Drawing.Point(174, 130);
            this.catRadioButton.Name = "catRadioButton";
            this.catRadioButton.Size = new System.Drawing.Size(60, 24);
            this.catRadioButton.TabIndex = 5;
            this.catRadioButton.TabStop = true;
            this.catRadioButton.Text = "Cat";
            this.catRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeIfOtherLabel
            // 
            this.typeIfOtherLabel.AutoSize = true;
            this.typeIfOtherLabel.Enabled = false;
            this.typeIfOtherLabel.Location = new System.Drawing.Point(226, 169);
            this.typeIfOtherLabel.Name = "typeIfOtherLabel";
            this.typeIfOtherLabel.Size = new System.Drawing.Size(123, 20);
            this.typeIfOtherLabel.TabIndex = 16;
            this.typeIfOtherLabel.Text = "T&ype (if Other):";
            // 
            // typeIfOtherTextBox
            // 
            this.typeIfOtherTextBox.Enabled = false;
            this.typeIfOtherTextBox.Location = new System.Drawing.Point(355, 166);
            this.typeIfOtherTextBox.Name = "typeIfOtherTextBox";
            this.typeIfOtherTextBox.Size = new System.Drawing.Size(182, 27);
            this.typeIfOtherTextBox.TabIndex = 8;
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(174, 47);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(204, 27);
            this.petNameTextBox.TabIndex = 3;
            // 
            // petDOBMaskedTextBox
            // 
            this.petDOBMaskedTextBox.Location = new System.Drawing.Point(174, 82);
            this.petDOBMaskedTextBox.Mask = "00/00/0000";
            this.petDOBMaskedTextBox.Name = "petDOBMaskedTextBox";
            this.petDOBMaskedTextBox.Size = new System.Drawing.Size(100, 27);
            this.petDOBMaskedTextBox.TabIndex = 4;
            this.petDOBMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.AutoSize = true;
            this.petTypeLabel.Location = new System.Drawing.Point(77, 130);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.petTypeLabel.TabIndex = 10;
            this.petTypeLabel.Text = "Pe&t Type:";
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(69, 47);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(88, 20);
            this.petNameLabel.TabIndex = 8;
            this.petNameLabel.Text = "&Pet Name:";
            // 
            // petDateOfBirthLabel
            // 
            this.petDateOfBirthLabel.AutoSize = true;
            this.petDateOfBirthLabel.Location = new System.Drawing.Point(17, 85);
            this.petDateOfBirthLabel.Name = "petDateOfBirthLabel";
            this.petDateOfBirthLabel.Size = new System.Drawing.Size(140, 20);
            this.petDateOfBirthLabel.TabIndex = 6;
            this.petDateOfBirthLabel.Text = "P&et Date of Birth:";
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.furTrimmingCheckBox);
            this.servicesGroupBox.Controls.Add(this.shampooCheckBox);
            this.servicesGroupBox.Controls.Add(this.nailClippingCheckBox);
            this.servicesGroupBox.Controls.Add(this.totalFeeLabel);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalCheckBox);
            this.servicesGroupBox.Controls.Add(this.totalFeeLabelText);
            this.servicesGroupBox.Controls.Add(this.furTrimmingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.shampooPriceLabel);
            this.servicesGroupBox.Controls.Add(this.nailClippingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalPriceLabel);
            this.servicesGroupBox.Location = new System.Drawing.Point(12, 432);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(586, 185);
            this.servicesGroupBox.TabIndex = 0;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Services";
            // 
            // furTrimmingCheckBox
            // 
            this.furTrimmingCheckBox.AutoSize = true;
            this.furTrimmingCheckBox.Location = new System.Drawing.Point(304, 82);
            this.furTrimmingCheckBox.Name = "furTrimmingCheckBox";
            this.furTrimmingCheckBox.Size = new System.Drawing.Size(135, 24);
            this.furTrimmingCheckBox.TabIndex = 12;
            this.furTrimmingCheckBox.Text = "F&ur Trimming";
            this.furTrimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.AutoSize = true;
            this.shampooCheckBox.Location = new System.Drawing.Point(304, 38);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(105, 24);
            this.shampooCheckBox.TabIndex = 10;
            this.shampooCheckBox.Text = "&Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // nailClippingCheckBox
            // 
            this.nailClippingCheckBox.AutoSize = true;
            this.nailClippingCheckBox.Location = new System.Drawing.Point(21, 78);
            this.nailClippingCheckBox.Name = "nailClippingCheckBox";
            this.nailClippingCheckBox.Size = new System.Drawing.Size(129, 24);
            this.nailClippingCheckBox.TabIndex = 11;
            this.nailClippingCheckBox.Text = "&Nail Clipping";
            this.nailClippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.AutoSize = true;
            this.totalFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeeLabel.Location = new System.Drawing.Point(260, 136);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(71, 22);
            this.totalFeeLabel.TabIndex = 10;
            this.totalFeeLabel.Text = "            ";
            // 
            // fleaRemovalCheckBox
            // 
            this.fleaRemovalCheckBox.AutoSize = true;
            this.fleaRemovalCheckBox.Location = new System.Drawing.Point(21, 38);
            this.fleaRemovalCheckBox.Name = "fleaRemovalCheckBox";
            this.fleaRemovalCheckBox.Size = new System.Drawing.Size(137, 24);
            this.fleaRemovalCheckBox.TabIndex = 9;
            this.fleaRemovalCheckBox.Text = "&Flea Removal";
            this.fleaRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalFeeLabelText
            // 
            this.totalFeeLabelText.AutoSize = true;
            this.totalFeeLabelText.Location = new System.Drawing.Point(170, 136);
            this.totalFeeLabelText.Name = "totalFeeLabelText";
            this.totalFeeLabelText.Size = new System.Drawing.Size(84, 20);
            this.totalFeeLabelText.TabIndex = 5;
            this.totalFeeLabelText.Text = "Total Fee:";
            // 
            // furTrimmingPriceLabel
            // 
            this.furTrimmingPriceLabel.AutoSize = true;
            this.furTrimmingPriceLabel.Location = new System.Drawing.Point(457, 83);
            this.furTrimmingPriceLabel.Name = "furTrimmingPriceLabel";
            this.furTrimmingPriceLabel.Size = new System.Drawing.Size(59, 40);
            this.furTrimmingPriceLabel.TabIndex = 4;
            this.furTrimmingPriceLabel.Text = "PRICE\r\n\r\n";
            // 
            // shampooPriceLabel
            // 
            this.shampooPriceLabel.AutoSize = true;
            this.shampooPriceLabel.Location = new System.Drawing.Point(457, 42);
            this.shampooPriceLabel.Name = "shampooPriceLabel";
            this.shampooPriceLabel.Size = new System.Drawing.Size(59, 20);
            this.shampooPriceLabel.TabIndex = 3;
            this.shampooPriceLabel.Text = "PRICE";
            // 
            // nailClippingPriceLabel
            // 
            this.nailClippingPriceLabel.AutoSize = true;
            this.nailClippingPriceLabel.Location = new System.Drawing.Point(170, 83);
            this.nailClippingPriceLabel.Name = "nailClippingPriceLabel";
            this.nailClippingPriceLabel.Size = new System.Drawing.Size(59, 20);
            this.nailClippingPriceLabel.TabIndex = 2;
            this.nailClippingPriceLabel.Text = "PRICE";
            // 
            // fleaRemovalPriceLabel
            // 
            this.fleaRemovalPriceLabel.AutoSize = true;
            this.fleaRemovalPriceLabel.Location = new System.Drawing.Point(170, 42);
            this.fleaRemovalPriceLabel.Name = "fleaRemovalPriceLabel";
            this.fleaRemovalPriceLabel.Size = new System.Drawing.Size(59, 20);
            this.fleaRemovalPriceLabel.TabIndex = 1;
            this.fleaRemovalPriceLabel.Text = "PRICE";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(69, 623);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(100, 30);
            this.totalButton.TabIndex = 13;
            this.totalButton.Text = "T&otal";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(250, 623);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(410, 623);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 30);
            this.quitButton.TabIndex = 15;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 693);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.petGroupBox);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.petOwnerGroupBox);
            this.Name = "Form1";
            this.Text = "Pet Boutique - Service Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.petOwnerGroupBox.ResumeLayout(false);
            this.petOwnerGroupBox.PerformLayout();
            this.petGroupBox.ResumeLayout(false);
            this.petGroupBox.PerformLayout();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox petOwnerGroupBox;
        private System.Windows.Forms.GroupBox petGroupBox;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.Label petDateOfBirthLabel;
        private System.Windows.Forms.Label totalFeeLabelText;
        private System.Windows.Forms.Label furTrimmingPriceLabel;
        private System.Windows.Forms.Label shampooPriceLabel;
        private System.Windows.Forms.Label nailClippingPriceLabel;
        private System.Windows.Forms.Label fleaRemovalPriceLabel;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.Label ownerPhoneLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.MaskedTextBox ownerPhoneMaskedTextBox;
        private System.Windows.Forms.Label typeIfOtherLabel;
        private System.Windows.Forms.TextBox typeIfOtherTextBox;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.MaskedTextBox petDOBMaskedTextBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.RadioButton catRadioButton;
        private System.Windows.Forms.CheckBox fleaRemovalCheckBox;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.CheckBox furTrimmingCheckBox;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.CheckBox nailClippingCheckBox;
    }
}

