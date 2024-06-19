namespace Bikowski_3
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.zipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homeDeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.storePickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.orderDetails = new System.Windows.Forms.GroupBox();
            this.characterLimitLabel = new System.Windows.Forms.Label();
            this.customWishesTextBox = new System.Windows.Forms.TextBox();
            this.customWishesPriceLabel = new System.Windows.Forms.Label();
            this.customWishesCheckBox = new System.Windows.Forms.CheckBox();
            this.extrasPriceLabel = new System.Windows.Forms.Label();
            this.occasionLabel = new System.Windows.Forms.Label();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.occasionComboBox = new System.Windows.Forms.ComboBox();
            this.dozenPriceLabel = new System.Windows.Forms.Label();
            this.halfDozenPriceLabel = new System.Windows.Forms.Label();
            this.singlePriceLabel = new System.Windows.Forms.Label();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDozenRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.orderTotals = new System.Windows.Forms.GroupBox();
            this.orderTotalValueLabel = new System.Windows.Forms.Label();
            this.salesTaxValueLabel = new System.Windows.Forms.Label();
            this.subtotalValueLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.displaySummaryButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.displaySummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerInfoGroupBox.SuspendLayout();
            this.deliveryInfo.SuspendLayout();
            this.orderDetails.SuspendLayout();
            this.orderTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bikowski_3.Properties.Resources._1312585521_origin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.zipMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.stateMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.streetTextBox);
            this.customerInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.cityTextBox);
            this.customerInfoGroupBox.Controls.Add(this.phoneLabel);
            this.customerInfoGroupBox.Controls.Add(this.titleLabel);
            this.customerInfoGroupBox.Controls.Add(this.zipLabel);
            this.customerInfoGroupBox.Controls.Add(this.stateLabel);
            this.customerInfoGroupBox.Controls.Add(this.cityLabel);
            this.customerInfoGroupBox.Controls.Add(this.streetLabel);
            this.customerInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.titleComboBox);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(22, 264);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(838, 153);
            this.customerInfoGroupBox.TabIndex = 1;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            // 
            // zipMaskedTextBox
            // 
            this.zipMaskedTextBox.Location = new System.Drawing.Point(408, 103);
            this.zipMaskedTextBox.Mask = "00000";
            this.zipMaskedTextBox.Name = "zipMaskedTextBox";
            this.zipMaskedTextBox.Size = new System.Drawing.Size(55, 27);
            this.zipMaskedTextBox.TabIndex = 15;
            this.zipMaskedTextBox.ValidatingType = typeof(int);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(652, 62);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(126, 27);
            this.phoneNumberMaskedTextBox.TabIndex = 14;
            // 
            // stateMaskedTextBox
            // 
            this.stateMaskedTextBox.Location = new System.Drawing.Point(311, 103);
            this.stateMaskedTextBox.Mask = "__";
            this.stateMaskedTextBox.Name = "stateMaskedTextBox";
            this.stateMaskedTextBox.Size = new System.Drawing.Size(31, 27);
            this.stateMaskedTextBox.TabIndex = 13;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(311, 23);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 27);
            this.streetTextBox.TabIndex = 12;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(106, 62);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.firstNameTextBox.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(106, 103);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(311, 62);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 27);
            this.cityTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(521, 65);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(125, 20);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(54, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(364, 106);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(38, 20);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "ZIP:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(252, 103);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(53, 20);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(262, 65);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 20);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(246, 26);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(59, 20);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 110);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 72);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 20);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev."});
            this.titleComboBox.Location = new System.Drawing.Point(106, 23);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(100, 28);
            this.titleComboBox.TabIndex = 0;
            // 
            // deliveryInfo
            // 
            this.deliveryInfo.Controls.Add(this.label1);
            this.deliveryInfo.Controls.Add(this.homeDeliveryRadioButton);
            this.deliveryInfo.Controls.Add(this.storePickUpRadioButton);
            this.deliveryInfo.Controls.Add(this.deliveryDateLabel);
            this.deliveryInfo.Controls.Add(this.dateMaskedTextBox);
            this.deliveryInfo.Location = new System.Drawing.Point(12, 433);
            this.deliveryInfo.Name = "deliveryInfo";
            this.deliveryInfo.Size = new System.Drawing.Size(848, 85);
            this.deliveryInfo.TabIndex = 2;
            this.deliveryInfo.TabStop = false;
            this.deliveryInfo.Text = "Delivery Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(673, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "$7.50";
            // 
            // homeDeliveryRadioButton
            // 
            this.homeDeliveryRadioButton.AutoSize = true;
            this.homeDeliveryRadioButton.Location = new System.Drawing.Point(522, 43);
            this.homeDeliveryRadioButton.Name = "homeDeliveryRadioButton";
            this.homeDeliveryRadioButton.Size = new System.Drawing.Size(145, 24);
            this.homeDeliveryRadioButton.TabIndex = 3;
            this.homeDeliveryRadioButton.Text = "Home Delivery";
            this.homeDeliveryRadioButton.UseVisualStyleBackColor = true;
            this.homeDeliveryRadioButton.CheckedChanged += new System.EventHandler(this.homeDeliveryRadioButton_CheckedChanged);
            // 
            // storePickUpRadioButton
            // 
            this.storePickUpRadioButton.AutoSize = true;
            this.storePickUpRadioButton.Checked = true;
            this.storePickUpRadioButton.Location = new System.Drawing.Point(378, 43);
            this.storePickUpRadioButton.Name = "storePickUpRadioButton";
            this.storePickUpRadioButton.Size = new System.Drawing.Size(138, 24);
            this.storePickUpRadioButton.TabIndex = 2;
            this.storePickUpRadioButton.TabStop = true;
            this.storePickUpRadioButton.Text = "Store Pick-Up";
            this.storePickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(6, 43);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(180, 20);
            this.deliveryDateLabel.TabIndex = 1;
            this.deliveryDateLabel.Text = "Desired Delivery Date:";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(192, 40);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 27);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // orderDetails
            // 
            this.orderDetails.Controls.Add(this.characterLimitLabel);
            this.orderDetails.Controls.Add(this.customWishesTextBox);
            this.orderDetails.Controls.Add(this.customWishesPriceLabel);
            this.orderDetails.Controls.Add(this.customWishesCheckBox);
            this.orderDetails.Controls.Add(this.extrasPriceLabel);
            this.orderDetails.Controls.Add(this.occasionLabel);
            this.orderDetails.Controls.Add(this.extrasLabel);
            this.orderDetails.Controls.Add(this.extrasListBox);
            this.orderDetails.Controls.Add(this.occasionComboBox);
            this.orderDetails.Controls.Add(this.dozenPriceLabel);
            this.orderDetails.Controls.Add(this.halfDozenPriceLabel);
            this.orderDetails.Controls.Add(this.singlePriceLabel);
            this.orderDetails.Controls.Add(this.singleRadioButton);
            this.orderDetails.Controls.Add(this.halfDozenRadioButton);
            this.orderDetails.Controls.Add(this.radioButton5);
            this.orderDetails.Location = new System.Drawing.Point(12, 524);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(848, 156);
            this.orderDetails.TabIndex = 0;
            this.orderDetails.TabStop = false;
            this.orderDetails.Text = "Order Details";
            // 
            // characterLimitLabel
            // 
            this.characterLimitLabel.AutoSize = true;
            this.characterLimitLabel.Enabled = false;
            this.characterLimitLabel.Location = new System.Drawing.Point(642, 97);
            this.characterLimitLabel.Name = "characterLimitLabel";
            this.characterLimitLabel.Size = new System.Drawing.Size(151, 20);
            this.characterLimitLabel.TabIndex = 16;
            this.characterLimitLabel.Text = "(30 character limit)";
            // 
            // customWishesTextBox
            // 
            this.customWishesTextBox.Enabled = false;
            this.customWishesTextBox.Location = new System.Drawing.Point(276, 95);
            this.customWishesTextBox.MaxLength = 30;
            this.customWishesTextBox.Name = "customWishesTextBox";
            this.customWishesTextBox.Size = new System.Drawing.Size(360, 27);
            this.customWishesTextBox.TabIndex = 15;
            // 
            // customWishesPriceLabel
            // 
            this.customWishesPriceLabel.AutoSize = true;
            this.customWishesPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customWishesPriceLabel.Location = new System.Drawing.Point(437, 63);
            this.customWishesPriceLabel.Name = "customWishesPriceLabel";
            this.customWishesPriceLabel.Size = new System.Drawing.Size(51, 22);
            this.customWishesPriceLabel.TabIndex = 14;
            this.customWishesPriceLabel.Text = "$2.50";
            // 
            // customWishesCheckBox
            // 
            this.customWishesCheckBox.AutoSize = true;
            this.customWishesCheckBox.Location = new System.Drawing.Point(277, 62);
            this.customWishesCheckBox.Name = "customWishesCheckBox";
            this.customWishesCheckBox.Size = new System.Drawing.Size(154, 24);
            this.customWishesCheckBox.TabIndex = 13;
            this.customWishesCheckBox.Text = "Custom Wishes";
            this.customWishesCheckBox.UseVisualStyleBackColor = true;
            // 
            // extrasPriceLabel
            // 
            this.extrasPriceLabel.AutoSize = true;
            this.extrasPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extrasPriceLabel.Location = new System.Drawing.Point(599, 29);
            this.extrasPriceLabel.Name = "extrasPriceLabel";
            this.extrasPriceLabel.Size = new System.Drawing.Size(51, 22);
            this.extrasPriceLabel.TabIndex = 12;
            this.extrasPriceLabel.Text = "$9.50";
            // 
            // occasionLabel
            // 
            this.occasionLabel.AutoSize = true;
            this.occasionLabel.Location = new System.Drawing.Point(273, 30);
            this.occasionLabel.Name = "occasionLabel";
            this.occasionLabel.Size = new System.Drawing.Size(85, 20);
            this.occasionLabel.TabIndex = 11;
            this.occasionLabel.Text = "Occasion:";
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Location = new System.Drawing.Point(531, 29);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(62, 20);
            this.extrasLabel.TabIndex = 10;
            this.extrasLabel.Text = "Extras:";
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.ItemHeight = 20;
            this.extrasListBox.Location = new System.Drawing.Point(662, 28);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(131, 24);
            this.extrasListBox.TabIndex = 9;
            // 
            // occasionComboBox
            // 
            this.occasionComboBox.FormattingEnabled = true;
            this.occasionComboBox.Location = new System.Drawing.Point(364, 26);
            this.occasionComboBox.Name = "occasionComboBox";
            this.occasionComboBox.Size = new System.Drawing.Size(121, 28);
            this.occasionComboBox.TabIndex = 5;
            // 
            // dozenPriceLabel
            // 
            this.dozenPriceLabel.AutoSize = true;
            this.dozenPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dozenPriceLabel.Location = new System.Drawing.Point(182, 95);
            this.dozenPriceLabel.Name = "dozenPriceLabel";
            this.dozenPriceLabel.Size = new System.Drawing.Size(60, 22);
            this.dozenPriceLabel.TabIndex = 8;
            this.dozenPriceLabel.Text = "$65.95";
            // 
            // halfDozenPriceLabel
            // 
            this.halfDozenPriceLabel.AutoSize = true;
            this.halfDozenPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.halfDozenPriceLabel.Location = new System.Drawing.Point(182, 62);
            this.halfDozenPriceLabel.Name = "halfDozenPriceLabel";
            this.halfDozenPriceLabel.Size = new System.Drawing.Size(60, 22);
            this.halfDozenPriceLabel.TabIndex = 7;
            this.halfDozenPriceLabel.Text = "$35.95";
            // 
            // singlePriceLabel
            // 
            this.singlePriceLabel.AutoSize = true;
            this.singlePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.singlePriceLabel.Location = new System.Drawing.Point(182, 30);
            this.singlePriceLabel.Name = "singlePriceLabel";
            this.singlePriceLabel.Size = new System.Drawing.Size(51, 22);
            this.singlePriceLabel.TabIndex = 6;
            this.singlePriceLabel.Text = "$9.95";
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Checked = true;
            this.singleRadioButton.Location = new System.Drawing.Point(57, 28);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(80, 24);
            this.singleRadioButton.TabIndex = 3;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // halfDozenRadioButton
            // 
            this.halfDozenRadioButton.AutoSize = true;
            this.halfDozenRadioButton.Location = new System.Drawing.Point(57, 58);
            this.halfDozenRadioButton.Name = "halfDozenRadioButton";
            this.halfDozenRadioButton.Size = new System.Drawing.Size(119, 24);
            this.halfDozenRadioButton.TabIndex = 4;
            this.halfDozenRadioButton.Text = "Half Dozen";
            this.halfDozenRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(57, 88);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(83, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Dozen";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // orderTotals
            // 
            this.orderTotals.Controls.Add(this.orderTotalValueLabel);
            this.orderTotals.Controls.Add(this.salesTaxValueLabel);
            this.orderTotals.Controls.Add(this.subtotalValueLabel);
            this.orderTotals.Controls.Add(this.orderTotalLabel);
            this.orderTotals.Controls.Add(this.salesTaxLabel);
            this.orderTotals.Controls.Add(this.subtotalLabel);
            this.orderTotals.Location = new System.Drawing.Point(12, 686);
            this.orderTotals.Name = "orderTotals";
            this.orderTotals.Size = new System.Drawing.Size(848, 62);
            this.orderTotals.TabIndex = 0;
            this.orderTotals.TabStop = false;
            this.orderTotals.Text = "Order Totals";
            // 
            // orderTotalValueLabel
            // 
            this.orderTotalValueLabel.AutoSize = true;
            this.orderTotalValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTotalValueLabel.Location = new System.Drawing.Point(742, 25);
            this.orderTotalValueLabel.Name = "orderTotalValueLabel";
            this.orderTotalValueLabel.Size = new System.Drawing.Size(51, 22);
            this.orderTotalValueLabel.TabIndex = 5;
            this.orderTotalValueLabel.Text = "$0.00";
            // 
            // salesTaxValueLabel
            // 
            this.salesTaxValueLabel.AutoSize = true;
            this.salesTaxValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxValueLabel.Location = new System.Drawing.Point(465, 27);
            this.salesTaxValueLabel.Name = "salesTaxValueLabel";
            this.salesTaxValueLabel.Size = new System.Drawing.Size(51, 22);
            this.salesTaxValueLabel.TabIndex = 4;
            this.salesTaxValueLabel.Text = "$0.00";
            // 
            // subtotalValueLabel
            // 
            this.subtotalValueLabel.AutoSize = true;
            this.subtotalValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalValueLabel.Location = new System.Drawing.Point(135, 25);
            this.subtotalValueLabel.Name = "subtotalValueLabel";
            this.subtotalValueLabel.Size = new System.Drawing.Size(51, 22);
            this.subtotalValueLabel.TabIndex = 3;
            this.subtotalValueLabel.Text = "$0.00";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(637, 25);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(99, 20);
            this.orderTotalLabel.TabIndex = 2;
            this.orderTotalLabel.Text = "Order Total:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(309, 29);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(150, 20);
            this.salesTaxLabel.TabIndex = 1;
            this.salesTaxLabel.Text = "Sales Tax Amount:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(54, 25);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(75, 20);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // displaySummaryButton
            // 
            this.displaySummaryButton.Location = new System.Drawing.Point(128, 773);
            this.displaySummaryButton.Name = "displaySummaryButton";
            this.displaySummaryButton.Size = new System.Drawing.Size(117, 56);
            this.displaySummaryButton.TabIndex = 17;
            this.displaySummaryButton.Text = "Display &Summary";
            this.displaySummaryToolTip.SetToolTip(this.displaySummaryButton, "Calculates Summary");
            this.displaySummaryButton.UseVisualStyleBackColor = true;
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(368, 773);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(117, 56);
            this.clearFormButton.TabIndex = 18;
            this.clearFormButton.Text = "&Clear Form";
            this.clearFormToolTip.SetToolTip(this.clearFormButton, "Clears the Form of all Inputs");
            this.clearFormButton.UseVisualStyleBackColor = true;
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(608, 773);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(128, 56);
            this.exitProgramButton.TabIndex = 19;
            this.exitProgramButton.Text = "E&xit Program";
            this.exitToolTip.SetToolTip(this.exitProgramButton, "Exits the program");
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 888);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.displaySummaryButton);
            this.Controls.Add(this.orderTotals);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.deliveryInfo);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Bonnie\'s Balloons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.deliveryInfo.ResumeLayout(false);
            this.deliveryInfo.PerformLayout();
            this.orderDetails.ResumeLayout(false);
            this.orderDetails.PerformLayout();
            this.orderTotals.ResumeLayout(false);
            this.orderTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.GroupBox deliveryInfo;
        private System.Windows.Forms.GroupBox orderDetails;
        private System.Windows.Forms.GroupBox orderTotals;
        private System.Windows.Forms.MaskedTextBox stateMaskedTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MaskedTextBox zipMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton homeDeliveryRadioButton;
        private System.Windows.Forms.RadioButton storePickUpRadioButton;
        private System.Windows.Forms.Label dozenPriceLabel;
        private System.Windows.Forms.Label halfDozenPriceLabel;
        private System.Windows.Forms.Label singlePriceLabel;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.RadioButton halfDozenRadioButton;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label characterLimitLabel;
        private System.Windows.Forms.TextBox customWishesTextBox;
        private System.Windows.Forms.Label customWishesPriceLabel;
        private System.Windows.Forms.CheckBox customWishesCheckBox;
        private System.Windows.Forms.Label extrasPriceLabel;
        private System.Windows.Forms.Label occasionLabel;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.ComboBox occasionComboBox;
        private System.Windows.Forms.Label orderTotalValueLabel;
        private System.Windows.Forms.Label salesTaxValueLabel;
        private System.Windows.Forms.Label subtotalValueLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button displaySummaryButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.ToolTip displaySummaryToolTip;
        private System.Windows.Forms.ToolTip clearFormToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}

