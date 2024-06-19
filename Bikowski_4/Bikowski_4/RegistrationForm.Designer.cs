namespace Bikowski_4
{
    partial class RegistrationForm
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
            this.schoolNameLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.registrantInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.DOBMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registrationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.numOfClassesLabel = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.numOfClassesValueLabel = new System.Windows.Forms.Label();
            this.pricePerClassValueLabel = new System.Windows.Forms.Label();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButto = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.emailReceiptCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aboutToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.filmPictureBox = new System.Windows.Forms.PictureBox();
            this.registrantInfoGroupBox.SuspendLayout();
            this.registrationInfoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolNameLabel
            // 
            this.schoolNameLabel.AutoSize = true;
            this.schoolNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolNameLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 17.88535F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolNameLabel.Location = new System.Drawing.Point(25, 55);
            this.schoolNameLabel.Name = "schoolNameLabel";
            this.schoolNameLabel.Size = new System.Drawing.Size(213, 143);
            this.schoolNameLabel.TabIndex = 1;
            this.schoolNameLabel.Text = "Hopkins\r\nFilm \r\nSchool";
            this.schoolNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(348, 219);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 27);
            this.dateMaskedTextBox.TabIndex = 2;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(187, 222);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(145, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Registration Date:";
            // 
            // registrantInfoGroupBox
            // 
            this.registrantInfoGroupBox.Controls.Add(this.statusLabel);
            this.registrantInfoGroupBox.Controls.Add(this.statusComboBox);
            this.registrantInfoGroupBox.Controls.Add(this.DOBMaskedTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.emailTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.DOBLabel);
            this.registrantInfoGroupBox.Controls.Add(this.emailLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInfoGroupBox.Location = new System.Drawing.Point(25, 273);
            this.registrantInfoGroupBox.Name = "registrantInfoGroupBox";
            this.registrantInfoGroupBox.Size = new System.Drawing.Size(287, 250);
            this.registrantInfoGroupBox.TabIndex = 4;
            this.registrantInfoGroupBox.TabStop = false;
            this.registrantInfoGroupBox.Text = "Registrant Information";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(45, 191);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(91, 40);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Status of \r\nRegistrant:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.AllowDrop = true;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(150, 203);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 28);
            this.statusComboBox.TabIndex = 20;
            // 
            // DOBMaskedTextBox
            // 
            this.DOBMaskedTextBox.Location = new System.Drawing.Point(150, 148);
            this.DOBMaskedTextBox.Name = "DOBMaskedTextBox";
            this.DOBMaskedTextBox.Size = new System.Drawing.Size(100, 27);
            this.DOBMaskedTextBox.TabIndex = 19;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(150, 109);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 27);
            this.emailTextBox.TabIndex = 18;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(22, 151);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(114, 20);
            this.DOBLabel.TabIndex = 17;
            this.DOBLabel.Text = "Date Of Birth:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(13, 109);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(123, 20);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email Address:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(150, 33);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.firstNameTextBox.TabIndex = 15;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(150, 69);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.lastNameTextBox.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(40, 72);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 20);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(39, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 20);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name:";
            // 
            // registrationInfoGroupBox
            // 
            this.registrationInfoGroupBox.Controls.Add(this.classesListBox);
            this.registrationInfoGroupBox.Controls.Add(this.numOfClassesLabel);
            this.registrationInfoGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrationInfoGroupBox.Controls.Add(this.totalPriceLabel);
            this.registrationInfoGroupBox.Controls.Add(this.numOfClassesValueLabel);
            this.registrationInfoGroupBox.Controls.Add(this.pricePerClassValueLabel);
            this.registrationInfoGroupBox.Controls.Add(this.totalPriceValueLabel);
            this.registrationInfoGroupBox.Controls.Add(this.listBoxLabel);
            this.registrationInfoGroupBox.Controls.Add(this.animationRadioButton);
            this.registrationInfoGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrationInfoGroupBox.Location = new System.Drawing.Point(338, 273);
            this.registrationInfoGroupBox.Name = "registrationInfoGroupBox";
            this.registrationInfoGroupBox.Size = new System.Drawing.Size(337, 381);
            this.registrationInfoGroupBox.TabIndex = 0;
            this.registrationInfoGroupBox.TabStop = false;
            this.registrationInfoGroupBox.Text = "Registration Information";
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.ItemHeight = 20;
            this.classesListBox.Location = new System.Drawing.Point(58, 129);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classesListBox.Size = new System.Drawing.Size(201, 84);
            this.classesListBox.Sorted = true;
            this.classesListBox.TabIndex = 16;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged_1);
            // 
            // numOfClassesLabel
            // 
            this.numOfClassesLabel.AutoSize = true;
            this.numOfClassesLabel.Location = new System.Drawing.Point(6, 249);
            this.numOfClassesLabel.Name = "numOfClassesLabel";
            this.numOfClassesLabel.Size = new System.Drawing.Size(228, 20);
            this.numOfClassesLabel.TabIndex = 10;
            this.numOfClassesLabel.Text = "Number of Classes Selected:";
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.AutoSize = true;
            this.pricePerClassLabel.Location = new System.Drawing.Point(102, 284);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(132, 20);
            this.pricePerClassLabel.TabIndex = 11;
            this.pricePerClassLabel.Text = "Price Per Class:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(139, 316);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(95, 20);
            this.totalPriceLabel.TabIndex = 12;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // numOfClassesValueLabel
            // 
            this.numOfClassesValueLabel.AutoSize = true;
            this.numOfClassesValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfClassesValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.796178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfClassesValueLabel.Location = new System.Drawing.Point(247, 249);
            this.numOfClassesValueLabel.Name = "numOfClassesValueLabel";
            this.numOfClassesValueLabel.Size = new System.Drawing.Size(21, 22);
            this.numOfClassesValueLabel.TabIndex = 13;
            this.numOfClassesValueLabel.Text = "0";
            // 
            // pricePerClassValueLabel
            // 
            this.pricePerClassValueLabel.AutoSize = true;
            this.pricePerClassValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerClassValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.796178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerClassValueLabel.Location = new System.Drawing.Point(247, 284);
            this.pricePerClassValueLabel.Name = "pricePerClassValueLabel";
            this.pricePerClassValueLabel.Size = new System.Drawing.Size(56, 22);
            this.pricePerClassValueLabel.TabIndex = 14;
            this.pricePerClassValueLabel.Text = "$0.00";
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.AutoSize = true;
            this.totalPriceValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.796178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceValueLabel.Location = new System.Drawing.Point(247, 316);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(56, 22);
            this.totalPriceValueLabel.TabIndex = 15;
            this.totalPriceValueLabel.Text = "$0.00";
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Location = new System.Drawing.Point(11, 109);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(0, 20);
            this.listBoxLabel.TabIndex = 8;
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(15, 65);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(108, 24);
            this.animationRadioButton.TabIndex = 6;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Checked = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(15, 36);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(117, 24);
            this.liveActionRadioButton.TabIndex = 5;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // cashRadioButto
            // 
            this.cashRadioButto.AutoSize = true;
            this.cashRadioButto.Checked = true;
            this.cashRadioButto.Location = new System.Drawing.Point(191, 545);
            this.cashRadioButto.Name = "cashRadioButto";
            this.cashRadioButto.Size = new System.Drawing.Size(73, 24);
            this.cashRadioButto.TabIndex = 5;
            this.cashRadioButto.TabStop = true;
            this.cashRadioButto.Text = "Cash";
            this.cashRadioButto.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(191, 575);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(81, 24);
            this.checkRadioButton.TabIndex = 6;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(22, 547);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(139, 20);
            this.paymentMethodLabel.TabIndex = 7;
            this.paymentMethodLabel.Text = "Payment Method:";
            // 
            // emailReceiptCheckBox
            // 
            this.emailReceiptCheckBox.AutoSize = true;
            this.emailReceiptCheckBox.Location = new System.Drawing.Point(26, 616);
            this.emailReceiptCheckBox.Name = "emailReceiptCheckBox";
            this.emailReceiptCheckBox.Size = new System.Drawing.Size(153, 24);
            this.emailReceiptCheckBox.TabIndex = 8;
            this.emailReceiptCheckBox.Text = "Email Receipt ?";
            this.emailReceiptCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Saves the form and displays summary";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.ToolTipText = "Clears the form";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Exits the form";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Shows about us form";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveToolTip
            // 
            this.saveToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.saveToolTip_Popup);
            // 
            // filmPictureBox
            // 
            this.filmPictureBox.Image = global::Bikowski_4.Properties.Resources.film_stocks;
            this.filmPictureBox.Location = new System.Drawing.Point(266, 55);
            this.filmPictureBox.Name = "filmPictureBox";
            this.filmPictureBox.Size = new System.Drawing.Size(409, 143);
            this.filmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmPictureBox.TabIndex = 0;
            this.filmPictureBox.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 675);
            this.Controls.Add(this.emailReceiptCheckBox);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButto);
            this.Controls.Add(this.registrationInfoGroupBox);
            this.Controls.Add(this.registrantInfoGroupBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.schoolNameLabel);
            this.Controls.Add(this.filmPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.Text = "Hopkins Film School Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.registrantInfoGroupBox.ResumeLayout(false);
            this.registrantInfoGroupBox.PerformLayout();
            this.registrationInfoGroupBox.ResumeLayout(false);
            this.registrationInfoGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filmPictureBox;
        private System.Windows.Forms.Label schoolNameLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox registrantInfoGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.MaskedTextBox DOBMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox registrationInfoGroupBox;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButto;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.CheckBox emailReceiptCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.ToolTip aboutToolTip;
        private System.Windows.Forms.Label numOfClassesLabel;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label numOfClassesValueLabel;
        private System.Windows.Forms.Label pricePerClassValueLabel;
        private System.Windows.Forms.Label totalPriceValueLabel;
        private System.Windows.Forms.ListBox classesListBox;
    }
}

