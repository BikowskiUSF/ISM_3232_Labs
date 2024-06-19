namespace Bikowski_2
{
    partial class orderForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.termInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.yearOfTermLabel = new System.Windows.Forms.Label();
            this.termSelectionLabel = new System.Windows.Forms.Label();
            this.termYearComboBox = new System.Windows.Forms.ComboBox();
            this.springTermRadioButton = new System.Windows.Forms.RadioButton();
            this.fallTermRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInfogroupBox = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.outOfStateResidencyButton = new System.Windows.Forms.RadioButton();
            this.inStateResidencyButton = new System.Windows.Forms.RadioButton();
            this.residencyStatusLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.studentIDMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.courseOrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfCoursesBox = new System.Windows.Forms.Label();
            this.numberOfCourseSelected = new System.Windows.Forms.Label();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceBox = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.expirationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.creditCardMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.termInfoGroupBox.SuspendLayout();
            this.studentInfogroupBox.SuspendLayout();
            this.courseOrderInfoGroupBox.SuspendLayout();
            this.paymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bikowski_2.Properties.Resources.languagePic2;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // termInfoGroupBox
            // 
            this.termInfoGroupBox.Controls.Add(this.yearOfTermLabel);
            this.termInfoGroupBox.Controls.Add(this.termSelectionLabel);
            this.termInfoGroupBox.Controls.Add(this.termYearComboBox);
            this.termInfoGroupBox.Controls.Add(this.springTermRadioButton);
            this.termInfoGroupBox.Controls.Add(this.fallTermRadioButton);
            this.termInfoGroupBox.Location = new System.Drawing.Point(53, 244);
            this.termInfoGroupBox.Name = "termInfoGroupBox";
            this.termInfoGroupBox.Size = new System.Drawing.Size(806, 83);
            this.termInfoGroupBox.TabIndex = 0;
            this.termInfoGroupBox.TabStop = false;
            this.termInfoGroupBox.Text = "Term Information";
            // 
            // yearOfTermLabel
            // 
            this.yearOfTermLabel.AutoSize = true;
            this.yearOfTermLabel.Location = new System.Drawing.Point(455, 38);
            this.yearOfTermLabel.Name = "yearOfTermLabel";
            this.yearOfTermLabel.Size = new System.Drawing.Size(111, 20);
            this.yearOfTermLabel.TabIndex = 4;
            this.yearOfTermLabel.Text = "Year of Term:";
            // 
            // termSelectionLabel
            // 
            this.termSelectionLabel.AutoSize = true;
            this.termSelectionLabel.Location = new System.Drawing.Point(12, 36);
            this.termSelectionLabel.Name = "termSelectionLabel";
            this.termSelectionLabel.Size = new System.Drawing.Size(127, 20);
            this.termSelectionLabel.TabIndex = 1;
            this.termSelectionLabel.Text = "Term Selection:";
            // 
            // termYearComboBox
            // 
            this.termYearComboBox.FormattingEnabled = true;
            this.termYearComboBox.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.termYearComboBox.Location = new System.Drawing.Point(585, 33);
            this.termYearComboBox.Name = "termYearComboBox";
            this.termYearComboBox.Size = new System.Drawing.Size(121, 28);
            this.termYearComboBox.TabIndex = 4;
            // 
            // springTermRadioButton
            // 
            this.springTermRadioButton.AutoSize = true;
            this.springTermRadioButton.Location = new System.Drawing.Point(286, 36);
            this.springTermRadioButton.Name = "springTermRadioButton";
            this.springTermRadioButton.Size = new System.Drawing.Size(126, 24);
            this.springTermRadioButton.TabIndex = 3;
            this.springTermRadioButton.Text = "Spring Term";
            this.springTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallTermRadioButton
            // 
            this.fallTermRadioButton.AutoSize = true;
            this.fallTermRadioButton.Checked = true;
            this.fallTermRadioButton.Location = new System.Drawing.Point(161, 36);
            this.fallTermRadioButton.Name = "fallTermRadioButton";
            this.fallTermRadioButton.Size = new System.Drawing.Size(105, 24);
            this.fallTermRadioButton.TabIndex = 2;
            this.fallTermRadioButton.TabStop = true;
            this.fallTermRadioButton.Text = "Fall Term";
            this.fallTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentInfogroupBox
            // 
            this.studentInfogroupBox.Controls.Add(this.emailTextBox);
            this.studentInfogroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInfogroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInfogroupBox.Controls.Add(this.outOfStateResidencyButton);
            this.studentInfogroupBox.Controls.Add(this.inStateResidencyButton);
            this.studentInfogroupBox.Controls.Add(this.residencyStatusLabel);
            this.studentInfogroupBox.Controls.Add(this.emailLabel);
            this.studentInfogroupBox.Controls.Add(this.lastNameLabel);
            this.studentInfogroupBox.Controls.Add(this.firstNameLabel);
            this.studentInfogroupBox.Controls.Add(this.studentIDLabel);
            this.studentInfogroupBox.Controls.Add(this.studentIDMaskedTextbox);
            this.studentInfogroupBox.Location = new System.Drawing.Point(53, 348);
            this.studentInfogroupBox.Name = "studentInfogroupBox";
            this.studentInfogroupBox.Size = new System.Drawing.Size(806, 150);
            this.studentInfogroupBox.TabIndex = 1;
            this.studentInfogroupBox.TabStop = false;
            this.studentInfogroupBox.Text = "Student Information";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(393, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(157, 27);
            this.emailTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(115, 91);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 27);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(115, 35);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(120, 27);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // outOfStateResidencyButton
            // 
            this.outOfStateResidencyButton.AutoSize = true;
            this.outOfStateResidencyButton.Location = new System.Drawing.Point(590, 95);
            this.outOfStateResidencyButton.Name = "outOfStateResidencyButton";
            this.outOfStateResidencyButton.Size = new System.Drawing.Size(130, 24);
            this.outOfStateResidencyButton.TabIndex = 7;
            this.outOfStateResidencyButton.TabStop = true;
            this.outOfStateResidencyButton.Text = "Out-Of-State";
            this.outOfStateResidencyButton.UseVisualStyleBackColor = true;
            // 
            // inStateResidencyButton
            // 
            this.inStateResidencyButton.AutoSize = true;
            this.inStateResidencyButton.Checked = true;
            this.inStateResidencyButton.Location = new System.Drawing.Point(590, 64);
            this.inStateResidencyButton.Name = "inStateResidencyButton";
            this.inStateResidencyButton.Size = new System.Drawing.Size(92, 24);
            this.inStateResidencyButton.TabIndex = 6;
            this.inStateResidencyButton.TabStop = true;
            this.inStateResidencyButton.Text = "In-State";
            this.inStateResidencyButton.UseVisualStyleBackColor = true;
            this.inStateResidencyButton.CheckedChanged += new System.EventHandler(this.inStateResidencyButton_CheckedChanged);
            // 
            // residencyStatusLabel
            // 
            this.residencyStatusLabel.AutoSize = true;
            this.residencyStatusLabel.Location = new System.Drawing.Point(586, 41);
            this.residencyStatusLabel.Name = "residencyStatusLabel";
            this.residencyStatusLabel.Size = new System.Drawing.Size(145, 20);
            this.residencyStatusLabel.TabIndex = 5;
            this.residencyStatusLabel.Text = "Residency Status:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(252, 97);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(123, 20);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 91);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 20);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(282, 41);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(93, 20);
            this.studentIDLabel.TabIndex = 3;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // studentIDMaskedTextbox
            // 
            this.studentIDMaskedTextbox.Location = new System.Drawing.Point(393, 38);
            this.studentIDMaskedTextbox.Mask = "000-00-0000";
            this.studentIDMaskedTextbox.Name = "studentIDMaskedTextbox";
            this.studentIDMaskedTextbox.Size = new System.Drawing.Size(112, 27);
            this.studentIDMaskedTextbox.TabIndex = 4;
            // 
            // courseOrderInfoGroupBox
            // 
            this.courseOrderInfoGroupBox.Controls.Add(this.numberOfCoursesBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.numberOfCourseSelected);
            this.courseOrderInfoGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.label1);
            this.courseOrderInfoGroupBox.Location = new System.Drawing.Point(53, 516);
            this.courseOrderInfoGroupBox.Name = "courseOrderInfoGroupBox";
            this.courseOrderInfoGroupBox.Size = new System.Drawing.Size(812, 150);
            this.courseOrderInfoGroupBox.TabIndex = 2;
            this.courseOrderInfoGroupBox.TabStop = false;
            this.courseOrderInfoGroupBox.Text = "Course Order Information";
            // 
            // numberOfCoursesBox
            // 
            this.numberOfCoursesBox.AutoSize = true;
            this.numberOfCoursesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfCoursesBox.Location = new System.Drawing.Point(653, 120);
            this.numberOfCoursesBox.Name = "numberOfCoursesBox";
            this.numberOfCoursesBox.Size = new System.Drawing.Size(20, 22);
            this.numberOfCoursesBox.TabIndex = 7;
            this.numberOfCoursesBox.Text = "0";
            // 
            // numberOfCourseSelected
            // 
            this.numberOfCourseSelected.AutoSize = true;
            this.numberOfCourseSelected.Location = new System.Drawing.Point(487, 120);
            this.numberOfCourseSelected.Name = "numberOfCourseSelected";
            this.numberOfCourseSelected.Size = new System.Drawing.Size(160, 20);
            this.numberOfCourseSelected.TabIndex = 6;
            this.numberOfCourseSelected.Text = "Number of Courses:";
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(291, 120);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(175, 24);
            this.russianCheckBox.TabIndex = 5;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.russianCheckBox_CheckedChanged);
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(100, 120);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(174, 24);
            this.spanishCheckBox.TabIndex = 4;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.spanishCheckBox_CheckedChanged);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(491, 84);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(158, 24);
            this.italianCheckBox.TabIndex = 3;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.italianCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(291, 84);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(174, 24);
            this.germanCheckBox.TabIndex = 2;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.germanCheckBox_CheckedChanged);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(100, 84);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(166, 24);
            this.frenchCheckBox.TabIndex = 1;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "$49 per course for in-state and $99 per course for out-of-state.\r\n(Maximum of 3 c" +
    "ourses per order)\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // paymentInfoGroupBox
            // 
            this.paymentInfoGroupBox.Controls.Add(this.totalPriceBox);
            this.paymentInfoGroupBox.Controls.Add(this.totalPriceLabel);
            this.paymentInfoGroupBox.Controls.Add(this.label3);
            this.paymentInfoGroupBox.Controls.Add(this.expirationDateLabel);
            this.paymentInfoGroupBox.Controls.Add(this.expirationDateMaskedTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.creditCardMaskedTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentInfoGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInfoGroupBox.Location = new System.Drawing.Point(53, 685);
            this.paymentInfoGroupBox.Name = "paymentInfoGroupBox";
            this.paymentInfoGroupBox.Size = new System.Drawing.Size(812, 150);
            this.paymentInfoGroupBox.TabIndex = 3;
            this.paymentInfoGroupBox.TabStop = false;
            this.paymentInfoGroupBox.Text = "Payment Information";
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.AutoSize = true;
            this.totalPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceBox.Location = new System.Drawing.Point(414, 116);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.Size = new System.Drawing.Size(51, 22);
            this.totalPriceBox.TabIndex = 7;
            this.totalPriceBox.Text = "$0.00";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(317, 116);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(95, 20);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Credit Card Number:";
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Location = new System.Drawing.Point(389, 79);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(129, 20);
            this.expirationDateLabel.TabIndex = 4;
            this.expirationDateLabel.Text = "Expiration Date:";
            // 
            // expirationDateMaskedTextBox
            // 
            this.expirationDateMaskedTextBox.Location = new System.Drawing.Point(533, 76);
            this.expirationDateMaskedTextBox.Mask = "00/00/0000";
            this.expirationDateMaskedTextBox.Name = "expirationDateMaskedTextBox";
            this.expirationDateMaskedTextBox.Size = new System.Drawing.Size(100, 27);
            this.expirationDateMaskedTextBox.TabIndex = 5;
            this.expirationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // creditCardMaskedTextBox
            // 
            this.creditCardMaskedTextBox.Location = new System.Drawing.Point(533, 39);
            this.creditCardMaskedTextBox.Mask = "0000-0000-0000-0000";
            this.creditCardMaskedTextBox.Name = "creditCardMaskedTextBox";
            this.creditCardMaskedTextBox.Size = new System.Drawing.Size(182, 27);
            this.creditCardMaskedTextBox.TabIndex = 2;
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.AutoSize = true;
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(113, 38);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(122, 24);
            this.masterCardRadioButton.TabIndex = 0;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(113, 75);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(67, 24);
            this.visaRadioButton.TabIndex = 3;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 861);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 35);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Save";
            this.saveButtonToolTip.SetToolTip(this.saveButton, "Saves Invoice");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(393, 861);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 35);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButtonToolTip.SetToolTip(this.clearButton, "Clears the form.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(602, 861);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButtonToolTip.SetToolTip(this.exitButton, "Exits the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(920, 961);
            this.Controls.Add(this.courseOrderInfoGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.studentInfogroupBox);
            this.Controls.Add(this.paymentInfoGroupBox);
            this.Controls.Add(this.termInfoGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAI Order Form";
            this.Load += new System.EventHandler(this.orderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.termInfoGroupBox.ResumeLayout(false);
            this.termInfoGroupBox.PerformLayout();
            this.studentInfogroupBox.ResumeLayout(false);
            this.studentInfogroupBox.PerformLayout();
            this.courseOrderInfoGroupBox.ResumeLayout(false);
            this.courseOrderInfoGroupBox.PerformLayout();
            this.paymentInfoGroupBox.ResumeLayout(false);
            this.paymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox termInfoGroupBox;
        private System.Windows.Forms.GroupBox studentInfogroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox courseOrderInfoGroupBox;
        private System.Windows.Forms.GroupBox paymentInfoGroupBox;
        private System.Windows.Forms.ComboBox termYearComboBox;
        private System.Windows.Forms.RadioButton springTermRadioButton;
        private System.Windows.Forms.RadioButton fallTermRadioButton;
        private System.Windows.Forms.Label yearOfTermLabel;
        private System.Windows.Forms.Label termSelectionLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.RadioButton outOfStateResidencyButton;
        private System.Windows.Forms.RadioButton inStateResidencyButton;
        private System.Windows.Forms.Label residencyStatusLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.MaskedTextBox expirationDateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox creditCardMaskedTextBox;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.ToolTip saveButtonToolTip;
        private System.Windows.Forms.ToolTip clearButtonToolTip;
        private System.Windows.Forms.ToolTip exitButtonToolTip;
        private System.Windows.Forms.Label numberOfCoursesBox;
        private System.Windows.Forms.Label numberOfCourseSelected;
        private System.Windows.Forms.Label totalPriceBox;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

