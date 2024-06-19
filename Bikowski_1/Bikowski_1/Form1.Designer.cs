namespace Bikowski_1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.guestInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomNumberMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.nightlyRateTextBox = new System.Windows.Forms.TextBox();
            this.lengthOfStayTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.lengthOfStayLabel = new System.Windows.Forms.Label();
            this.nightlyRateLabel = new System.Windows.Forms.Label();
            this.checkoutDateLabel = new System.Windows.Forms.Label();
            this.additionalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.miniBarChargeLabel = new System.Windows.Forms.Label();
            this.telephoneChargesLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.miniBarChargeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneChargeTextBox = new System.Windows.Forms.TextBox();
            this.miscChargeTextBox = new System.Windows.Forms.TextBox();
            this.billingSumGroupBox = new System.Windows.Forms.GroupBox();
            this.roomChargeLabel = new System.Windows.Forms.Label();
            this.additionalChargeLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.roomChargeOutputBox = new System.Windows.Forms.TextBox();
            this.additonalChargeOutputBox = new System.Windows.Forms.TextBox();
            this.subtotalOutputBox = new System.Windows.Forms.TextBox();
            this.taxAmountOutputBox = new System.Windows.Forms.TextBox();
            this.totalChargesOutputBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.horizontalLineGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guestInformationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.additionalChargesGroupBox.SuspendLayout();
            this.billingSumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bikowski_1.Properties.Resources.motel;
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.17834F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(228, 260);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(334, 54);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Motorway Motel";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Location = new System.Drawing.Point(419, 329);
            this.maskedTextBoxDate.Mask = "(00/00/0000)";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(100, 27);
            this.maskedTextBoxDate.TabIndex = 3;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // guestInformationGroupBox
            // 
            this.guestInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.guestInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.guestInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.guestInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.guestInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.08917F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestInformationGroupBox.Location = new System.Drawing.Point(12, 369);
            this.guestInformationGroupBox.Name = "guestInformationGroupBox";
            this.guestInformationGroupBox.Size = new System.Drawing.Size(367, 148);
            this.guestInformationGroupBox.TabIndex = 4;
            this.guestInformationGroupBox.TabStop = false;
            this.guestInformationGroupBox.Text = "Guest Information";
            this.guestInformationGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(174, 47);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 32);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(174, 92);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 32);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(26, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(125, 26);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(26, 95);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(124, 26);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nightlyRateLabel);
            this.groupBox1.Controls.Add(this.lengthOfStayLabel);
            this.groupBox1.Controls.Add(this.roomNumberLabel);
            this.groupBox1.Controls.Add(this.lengthOfStayTextBox);
            this.groupBox1.Controls.Add(this.nightlyRateTextBox);
            this.groupBox1.Controls.Add(this.roomNumberMaskedBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.08917F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // roomNumberMaskedBox
            // 
            this.roomNumberMaskedBox.Location = new System.Drawing.Point(224, 37);
            this.roomNumberMaskedBox.Mask = "(000)";
            this.roomNumberMaskedBox.Name = "roomNumberMaskedBox";
            this.roomNumberMaskedBox.Size = new System.Drawing.Size(60, 32);
            this.roomNumberMaskedBox.TabIndex = 0;
            // 
            // nightlyRateTextBox
            // 
            this.nightlyRateTextBox.Location = new System.Drawing.Point(207, 110);
            this.nightlyRateTextBox.Name = "nightlyRateTextBox";
            this.nightlyRateTextBox.Size = new System.Drawing.Size(100, 32);
            this.nightlyRateTextBox.TabIndex = 1;
            // 
            // lengthOfStayTextBox
            // 
            this.lengthOfStayTextBox.Location = new System.Drawing.Point(207, 72);
            this.lengthOfStayTextBox.Name = "lengthOfStayTextBox";
            this.lengthOfStayTextBox.Size = new System.Drawing.Size(100, 32);
            this.lengthOfStayTextBox.TabIndex = 2;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(29, 37);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(161, 26);
            this.roomNumberLabel.TabIndex = 3;
            this.roomNumberLabel.Text = "Room Number:";
            // 
            // lengthOfStayLabel
            // 
            this.lengthOfStayLabel.AutoSize = true;
            this.lengthOfStayLabel.Location = new System.Drawing.Point(29, 72);
            this.lengthOfStayLabel.Name = "lengthOfStayLabel";
            this.lengthOfStayLabel.Size = new System.Drawing.Size(158, 26);
            this.lengthOfStayLabel.TabIndex = 4;
            this.lengthOfStayLabel.Text = "Length of Stay:";
            // 
            // nightlyRateLabel
            // 
            this.nightlyRateLabel.AutoSize = true;
            this.nightlyRateLabel.Location = new System.Drawing.Point(50, 110);
            this.nightlyRateLabel.Name = "nightlyRateLabel";
            this.nightlyRateLabel.Size = new System.Drawing.Size(137, 26);
            this.nightlyRateLabel.TabIndex = 5;
            this.nightlyRateLabel.Text = "Nightly Rate:";
            // 
            // checkoutDateLabel
            // 
            this.checkoutDateLabel.AutoSize = true;
            this.checkoutDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.08917F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDateLabel.Location = new System.Drawing.Point(236, 327);
            this.checkoutDateLabel.Name = "checkoutDateLabel";
            this.checkoutDateLabel.Size = new System.Drawing.Size(162, 26);
            this.checkoutDateLabel.TabIndex = 6;
            this.checkoutDateLabel.Text = "Checkout Date:";
            // 
            // additionalChargesGroupBox
            // 
            this.additionalChargesGroupBox.Controls.Add(this.miscChargeTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneChargeTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarChargeTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.miscChargesLabel);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneChargesLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarChargeLabel);
            this.additionalChargesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.08917F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalChargesGroupBox.Location = new System.Drawing.Point(12, 542);
            this.additionalChargesGroupBox.Name = "additionalChargesGroupBox";
            this.additionalChargesGroupBox.Size = new System.Drawing.Size(367, 148);
            this.additionalChargesGroupBox.TabIndex = 7;
            this.additionalChargesGroupBox.TabStop = false;
            this.additionalChargesGroupBox.Text = "Additional Charges";
            // 
            // miniBarChargeLabel
            // 
            this.miniBarChargeLabel.AutoSize = true;
            this.miniBarChargeLabel.Location = new System.Drawing.Point(64, 37);
            this.miniBarChargeLabel.Name = "miniBarChargeLabel";
            this.miniBarChargeLabel.Size = new System.Drawing.Size(186, 26);
            this.miniBarChargeLabel.TabIndex = 0;
            this.miniBarChargeLabel.Text = "Mini Bar Charges:";
            // 
            // telephoneChargesLabel
            // 
            this.telephoneChargesLabel.AutoSize = true;
            this.telephoneChargesLabel.Location = new System.Drawing.Point(43, 72);
            this.telephoneChargesLabel.Name = "telephoneChargesLabel";
            this.telephoneChargesLabel.Size = new System.Drawing.Size(207, 26);
            this.telephoneChargesLabel.TabIndex = 1;
            this.telephoneChargesLabel.Text = "Telephone Charges:";
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Location = new System.Drawing.Point(6, 110);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(244, 26);
            this.miscChargesLabel.TabIndex = 2;
            this.miscChargesLabel.Text = "Miscellaneous Charges:";
            // 
            // miniBarChargeTextBox
            // 
            this.miniBarChargeTextBox.Location = new System.Drawing.Point(261, 37);
            this.miniBarChargeTextBox.Name = "miniBarChargeTextBox";
            this.miniBarChargeTextBox.Size = new System.Drawing.Size(100, 32);
            this.miniBarChargeTextBox.TabIndex = 3;
            // 
            // telephoneChargeTextBox
            // 
            this.telephoneChargeTextBox.Location = new System.Drawing.Point(261, 72);
            this.telephoneChargeTextBox.Name = "telephoneChargeTextBox";
            this.telephoneChargeTextBox.Size = new System.Drawing.Size(100, 32);
            this.telephoneChargeTextBox.TabIndex = 4;
            // 
            // miscChargeTextBox
            // 
            this.miscChargeTextBox.Location = new System.Drawing.Point(261, 110);
            this.miscChargeTextBox.Name = "miscChargeTextBox";
            this.miscChargeTextBox.Size = new System.Drawing.Size(100, 32);
            this.miscChargeTextBox.TabIndex = 5;
            // 
            // billingSumGroupBox
            // 
            this.billingSumGroupBox.Controls.Add(this.horizontalLineGroupBox);
            this.billingSumGroupBox.Controls.Add(this.totalChargesOutputBox);
            this.billingSumGroupBox.Controls.Add(this.taxAmountOutputBox);
            this.billingSumGroupBox.Controls.Add(this.subtotalOutputBox);
            this.billingSumGroupBox.Controls.Add(this.additonalChargeOutputBox);
            this.billingSumGroupBox.Controls.Add(this.roomChargeOutputBox);
            this.billingSumGroupBox.Controls.Add(this.totalChargesLabel);
            this.billingSumGroupBox.Controls.Add(this.taxAmountLabel);
            this.billingSumGroupBox.Controls.Add(this.subtotalLabel);
            this.billingSumGroupBox.Controls.Add(this.additionalChargeLabel);
            this.billingSumGroupBox.Controls.Add(this.roomChargeLabel);
            this.billingSumGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.08917F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingSumGroupBox.Location = new System.Drawing.Point(385, 542);
            this.billingSumGroupBox.Name = "billingSumGroupBox";
            this.billingSumGroupBox.Size = new System.Drawing.Size(345, 252);
            this.billingSumGroupBox.TabIndex = 8;
            this.billingSumGroupBox.TabStop = false;
            this.billingSumGroupBox.Text = "Billing Summary";
            // 
            // roomChargeLabel
            // 
            this.roomChargeLabel.AutoSize = true;
            this.roomChargeLabel.Location = new System.Drawing.Point(43, 50);
            this.roomChargeLabel.Name = "roomChargeLabel";
            this.roomChargeLabel.Size = new System.Drawing.Size(165, 26);
            this.roomChargeLabel.TabIndex = 0;
            this.roomChargeLabel.Text = "Room Charges:";
            // 
            // additionalChargeLabel
            // 
            this.additionalChargeLabel.AutoSize = true;
            this.additionalChargeLabel.Location = new System.Drawing.Point(2, 91);
            this.additionalChargeLabel.Name = "additionalChargeLabel";
            this.additionalChargeLabel.Size = new System.Drawing.Size(202, 26);
            this.additionalChargeLabel.TabIndex = 1;
            this.additionalChargeLabel.Text = "Additional Charges:\r\n";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(106, 135);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(98, 26);
            this.subtotalLabel.TabIndex = 2;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.Location = new System.Drawing.Point(69, 171);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(135, 26);
            this.taxAmountLabel.TabIndex = 3;
            this.taxAmountLabel.Text = "Tax Amount:";
            this.taxAmountLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.AutoSize = true;
            this.totalChargesLabel.Location = new System.Drawing.Point(51, 214);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(153, 26);
            this.totalChargesLabel.TabIndex = 4;
            this.totalChargesLabel.Text = "Total Charges:";
            // 
            // roomChargeOutputBox
            // 
            this.roomChargeOutputBox.Location = new System.Drawing.Point(224, 50);
            this.roomChargeOutputBox.Name = "roomChargeOutputBox";
            this.roomChargeOutputBox.Size = new System.Drawing.Size(100, 32);
            this.roomChargeOutputBox.TabIndex = 5;
            // 
            // additonalChargeOutputBox
            // 
            this.additonalChargeOutputBox.Location = new System.Drawing.Point(224, 88);
            this.additonalChargeOutputBox.Name = "additonalChargeOutputBox";
            this.additonalChargeOutputBox.Size = new System.Drawing.Size(100, 32);
            this.additonalChargeOutputBox.TabIndex = 6;
            // 
            // subtotalOutputBox
            // 
            this.subtotalOutputBox.Location = new System.Drawing.Point(224, 126);
            this.subtotalOutputBox.Name = "subtotalOutputBox";
            this.subtotalOutputBox.Size = new System.Drawing.Size(100, 32);
            this.subtotalOutputBox.TabIndex = 7;
            // 
            // taxAmountOutputBox
            // 
            this.taxAmountOutputBox.Location = new System.Drawing.Point(224, 165);
            this.taxAmountOutputBox.Name = "taxAmountOutputBox";
            this.taxAmountOutputBox.Size = new System.Drawing.Size(100, 32);
            this.taxAmountOutputBox.TabIndex = 8;
            // 
            // totalChargesOutputBox
            // 
            this.totalChargesOutputBox.Location = new System.Drawing.Point(224, 214);
            this.totalChargesOutputBox.Name = "totalChargesOutputBox";
            this.totalChargesOutputBox.Size = new System.Drawing.Size(100, 32);
            this.totalChargesOutputBox.TabIndex = 9;
            this.totalChargesOutputBox.TextChanged += new System.EventHandler(this.totalChargesOutputBox_TextChanged);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(81, 841);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(121, 39);
            this.totalButton.TabIndex = 9;
            this.totalButton.Text = "&Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(241, 841);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 39);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(402, 841);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(106, 39);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "&Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(557, 841);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 39);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // horizontalLineGroupBox
            // 
            this.horizontalLineGroupBox.Location = new System.Drawing.Point(224, 205);
            this.horizontalLineGroupBox.Name = "horizontalLineGroupBox";
            this.horizontalLineGroupBox.Size = new System.Drawing.Size(100, 3);
            this.horizontalLineGroupBox.TabIndex = 13;
            this.horizontalLineGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 936);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.billingSumGroupBox);
            this.Controls.Add(this.additionalChargesGroupBox);
            this.Controls.Add(this.checkoutDateLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guestInformationGroupBox);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guestInformationGroupBox.ResumeLayout(false);
            this.guestInformationGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.additionalChargesGroupBox.ResumeLayout(false);
            this.additionalChargesGroupBox.PerformLayout();
            this.billingSumGroupBox.ResumeLayout(false);
            this.billingSumGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.GroupBox guestInformationGroupBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nightlyRateLabel;
        private System.Windows.Forms.Label lengthOfStayLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox lengthOfStayTextBox;
        private System.Windows.Forms.TextBox nightlyRateTextBox;
        private System.Windows.Forms.MaskedTextBox roomNumberMaskedBox;
        private System.Windows.Forms.Label checkoutDateLabel;
        private System.Windows.Forms.GroupBox additionalChargesGroupBox;
        private System.Windows.Forms.TextBox miscChargeTextBox;
        private System.Windows.Forms.TextBox telephoneChargeTextBox;
        private System.Windows.Forms.TextBox miniBarChargeTextBox;
        private System.Windows.Forms.Label miscChargesLabel;
        private System.Windows.Forms.Label telephoneChargesLabel;
        private System.Windows.Forms.Label miniBarChargeLabel;
        private System.Windows.Forms.GroupBox billingSumGroupBox;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label additionalChargeLabel;
        private System.Windows.Forms.Label roomChargeLabel;
        private System.Windows.Forms.TextBox totalChargesOutputBox;
        private System.Windows.Forms.TextBox taxAmountOutputBox;
        private System.Windows.Forms.TextBox subtotalOutputBox;
        private System.Windows.Forms.TextBox additonalChargeOutputBox;
        private System.Windows.Forms.TextBox roomChargeOutputBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox horizontalLineGroupBox;
    }
}

