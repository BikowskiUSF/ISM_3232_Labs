// Programmer: Remy Bikowski
// Project: Lab 3-1
// Date: 02/18/2022
// Description: Form for taking a per care order.
using System;
using System.Windows.Forms;

namespace Lab_3_1
{
    public partial class Form1 : Form
    {
        // Declare constants for service fees
        private const decimal FLEA_REMOVAL_PRICE = 5.00m;
        private const decimal NAIL_CLIPPING_PRICE = 4.50m;
        private const decimal SHAMPOO_PRICE = 4.00m;
        private const decimal FUR_TRIMMING_PRICE = 9.00m;

        public Form1()
        {
            InitializeComponent();
        }
        


        // variables are loaded at program startup
        private void Form1_Load(object sender, EventArgs e)
        {
            // Assign the service prices to price labels on form
            fleaRemovalPriceLabel.Text = FLEA_REMOVAL_PRICE.ToString("c");
            nailClippingPriceLabel.Text = NAIL_CLIPPING_PRICE.ToString("c");
            shampooPriceLabel.Text = SHAMPOO_PRICE.ToString("c");
            furTrimmingPriceLabel.Text = FUR_TRIMMING_PRICE.ToString("C");
        }


        // Handle Other radio button's checked change event
        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Show typeifother Textbox and label when the "other" radio button is clicked/unclicked
            if (otherRadioButton.Checked)
            {
                typeIfOtherLabel.Enabled = true;
                typeIfOtherTextBox.Enabled = true;
                typeIfOtherTextBox.Focus();
            }
            else
            {
                typeIfOtherLabel.Enabled = false;
                typeIfOtherTextBox.Enabled = false;
                typeIfOtherTextBox.Text = ""; //Clear textbox
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            // Declare and set local variable for total fee
            decimal totalFee = 0.00m;

            // Use if statements to calculate total fee (if box is checked, add fee)
            if(fleaRemovalCheckBox.Checked)
            {
                totalFee += FLEA_REMOVAL_PRICE;
            }
            if(nailClippingCheckBox.Checked)
            {
                totalFee += NAIL_CLIPPING_PRICE;
            }
            if (shampooCheckBox.Checked)
            {
                totalFee += SHAMPOO_PRICE;
            }
            if(furTrimmingCheckBox.Checked)
            {
                totalFee += FUR_TRIMMING_PRICE;
            }

            // Display total fee in totalFeeLabel as $
            totalFeeLabel.Text = totalFee.ToString("C");

            // Change focus to Clear Button
            clearButton.Focus();
        }
// Execute clear button click event
        private void clearButton_Click(object sender, EventArgs e)
        {
            ownerNameTextBox.Text = "";
            ownerPhoneMaskedTextBox.Text = "";
            petNameTextBox.Text = "";
            petDOBMaskedTextBox.Text = "";
            catRadioButton.Text = "";
            catRadioButton.Checked = true;
            fleaRemovalCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
            totalFeeLabel.Text = "";

            // Change focus to ownerNameTextBox
            ownerNameTextBox.Focus();
        }
        // Execute quit button click event
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

    }
}
