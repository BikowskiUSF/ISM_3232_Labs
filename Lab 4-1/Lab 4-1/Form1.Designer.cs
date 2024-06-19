namespace Lab_4_1
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
            this.salesDateLabel = new System.Windows.Forms.Label();
            this.saleDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.propertyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.countyGroupBox = new System.Windows.Forms.GroupBox();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsboroughRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.countyTaxLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.horizontalLineGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stateTaxValueLabel = new System.Windows.Forms.Label();
            this.countyTaxValueLabel = new System.Windows.Forms.Label();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.commissionValueLabel = new System.Windows.Forms.Label();
            this.propertyTypeGroupBox.SuspendLayout();
            this.countyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesDateLabel
            // 
            this.salesDateLabel.AutoSize = true;
            this.salesDateLabel.Location = new System.Drawing.Point(92, 38);
            this.salesDateLabel.Name = "salesDateLabel";
            this.salesDateLabel.Size = new System.Drawing.Size(97, 20);
            this.salesDateLabel.TabIndex = 0;
            this.salesDateLabel.Text = "Sales Date:";
            // 
            // saleDateMaskedTextBox
            // 
            this.saleDateMaskedTextBox.Location = new System.Drawing.Point(195, 35);
            this.saleDateMaskedTextBox.Mask = "00/00/0000";
            this.saleDateMaskedTextBox.Name = "saleDateMaskedTextBox";
            this.saleDateMaskedTextBox.Size = new System.Drawing.Size(94, 27);
            this.saleDateMaskedTextBox.TabIndex = 1;
            this.saleDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // propertyTypeGroupBox
            // 
            this.propertyTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.residentialRadioButton);
            this.propertyTypeGroupBox.Location = new System.Drawing.Point(89, 81);
            this.propertyTypeGroupBox.Name = "propertyTypeGroupBox";
            this.propertyTypeGroupBox.Size = new System.Drawing.Size(200, 108);
            this.propertyTypeGroupBox.TabIndex = 2;
            this.propertyTypeGroupBox.TabStop = false;
            this.propertyTypeGroupBox.Text = "Property Type";
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(33, 65);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(124, 24);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(33, 35);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(117, 24);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // countyGroupBox
            // 
            this.countyGroupBox.Controls.Add(this.polkRadioButton);
            this.countyGroupBox.Controls.Add(this.pascoRadioButton);
            this.countyGroupBox.Controls.Add(this.hillsboroughRadioButton);
            this.countyGroupBox.Location = new System.Drawing.Point(89, 206);
            this.countyGroupBox.Name = "countyGroupBox";
            this.countyGroupBox.Size = new System.Drawing.Size(200, 119);
            this.countyGroupBox.TabIndex = 3;
            this.countyGroupBox.TabStop = false;
            this.countyGroupBox.Text = "County";
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.AutoSize = true;
            this.polkRadioButton.Location = new System.Drawing.Point(33, 86);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(66, 24);
            this.polkRadioButton.TabIndex = 6;
            this.polkRadioButton.Text = "Polk";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(33, 56);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(81, 24);
            this.pascoRadioButton.TabIndex = 5;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            this.pascoRadioButton.CheckedChanged += new System.EventHandler(this.pascoRadioButton_CheckedChanged);
            // 
            // hillsboroughRadioButton
            // 
            this.hillsboroughRadioButton.AutoSize = true;
            this.hillsboroughRadioButton.Checked = true;
            this.hillsboroughRadioButton.Location = new System.Drawing.Point(33, 26);
            this.hillsboroughRadioButton.Name = "hillsboroughRadioButton";
            this.hillsboroughRadioButton.Size = new System.Drawing.Size(128, 24);
            this.hillsboroughRadioButton.TabIndex = 4;
            this.hillsboroughRadioButton.TabStop = true;
            this.hillsboroughRadioButton.Text = "Hillsborough";
            this.hillsboroughRadioButton.UseVisualStyleBackColor = true;
            this.hillsboroughRadioButton.CheckedChanged += new System.EventHandler(this.hillsboroughRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Property Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(195, 338);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 27);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(89, 387);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 29);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "&Update Property Price";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.Location = new System.Drawing.Point(57, 446);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(132, 20);
            this.stateTaxLabel.TabIndex = 7;
            this.stateTaxLabel.Text = "State Sales Tax:";
            // 
            // countyTaxLabel
            // 
            this.countyTaxLabel.AutoSize = true;
            this.countyTaxLabel.Location = new System.Drawing.Point(44, 487);
            this.countyTaxLabel.Name = "countyTaxLabel";
            this.countyTaxLabel.Size = new System.Drawing.Size(145, 20);
            this.countyTaxLabel.TabIndex = 8;
            this.countyTaxLabel.Text = "County Sales Tax:";
            // 
            // commissionLabel
            // 
            this.commissionLabel.AutoSize = true;
            this.commissionLabel.Location = new System.Drawing.Point(81, 526);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(107, 20);
            this.commissionLabel.TabIndex = 9;
            this.commissionLabel.Text = "Commission:";
            // 
            // horizontalLineGroupBox
            // 
            this.horizontalLineGroupBox.Location = new System.Drawing.Point(195, 563);
            this.horizontalLineGroupBox.Name = "horizontalLineGroupBox";
            this.horizontalLineGroupBox.Size = new System.Drawing.Size(114, 3);
            this.horizontalLineGroupBox.TabIndex = 10;
            this.horizontalLineGroupBox.TabStop = false;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(94, 588);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(95, 20);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 642);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 32);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(149, 642);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 32);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(282, 642);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stateTaxValueLabel
            // 
            this.stateTaxValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateTaxValueLabel.Location = new System.Drawing.Point(214, 441);
            this.stateTaxValueLabel.Name = "stateTaxValueLabel";
            this.stateTaxValueLabel.Size = new System.Drawing.Size(75, 25);
            this.stateTaxValueLabel.TabIndex = 15;
            this.stateTaxValueLabel.Text = "$0.00";
            this.stateTaxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countyTaxValueLabel
            // 
            this.countyTaxValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countyTaxValueLabel.Location = new System.Drawing.Point(214, 482);
            this.countyTaxValueLabel.Name = "countyTaxValueLabel";
            this.countyTaxValueLabel.Size = new System.Drawing.Size(75, 25);
            this.countyTaxValueLabel.TabIndex = 16;
            this.countyTaxValueLabel.Text = "$0.00";
            this.countyTaxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceValueLabel.Location = new System.Drawing.Point(214, 586);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(75, 25);
            this.totalPriceValueLabel.TabIndex = 17;
            this.totalPriceValueLabel.Text = "$0.00";
            this.totalPriceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commissionValueLabel
            // 
            this.commissionValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionValueLabel.Location = new System.Drawing.Point(214, 524);
            this.commissionValueLabel.Name = "commissionValueLabel";
            this.commissionValueLabel.Size = new System.Drawing.Size(75, 25);
            this.commissionValueLabel.TabIndex = 18;
            this.commissionValueLabel.Text = "$0.00";
            this.commissionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 705);
            this.Controls.Add(this.commissionValueLabel);
            this.Controls.Add(this.totalPriceValueLabel);
            this.Controls.Add(this.countyTaxValueLabel);
            this.Controls.Add(this.stateTaxValueLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.horizontalLineGroupBox);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.countyTaxLabel);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countyGroupBox);
            this.Controls.Add(this.propertyTypeGroupBox);
            this.Controls.Add(this.saleDateMaskedTextBox);
            this.Controls.Add(this.salesDateLabel);
            this.Name = "Form1";
            this.Text = "Real Estate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.propertyTypeGroupBox.ResumeLayout(false);
            this.propertyTypeGroupBox.PerformLayout();
            this.countyGroupBox.ResumeLayout(false);
            this.countyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salesDateLabel;
        private System.Windows.Forms.MaskedTextBox saleDateMaskedTextBox;
        private System.Windows.Forms.GroupBox propertyTypeGroupBox;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.GroupBox countyGroupBox;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton hillsboroughRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label countyTaxLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.GroupBox horizontalLineGroupBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label stateTaxValueLabel;
        private System.Windows.Forms.Label countyTaxValueLabel;
        private System.Windows.Forms.Label totalPriceValueLabel;
        private System.Windows.Forms.Label commissionValueLabel;
    }
}

