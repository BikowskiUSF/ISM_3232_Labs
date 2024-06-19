// Programmer: Remy Bikowski
// Project: Assignment 3
// Date: 04/08/2022
// Description: Bonnie's Balloons invoice creator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // add to allow the use of StreamWriter

namespace Bikowski_3
{
    public partial class Form1 : Form
    {
        // Declare constants for all price labels in form
        private const decimal HOME_DELIVERY_PRICE = 7.50m;
        private const decimal SINGLE_BALLOON_PRICE = 9.95m;
        private const decimal HALF_DOZEN_BALLOON_PRICE = 35.95m;
        private const decimal DOZEN_BALLOON_PRICE = 65.95m;
        private const decimal EXTRAS_PRICE = 9.50m;
        private const decimal PERSONAL_MESSAGE_PRICE = 2.50m;
        private const decimal SALES_TAX = 0.07m;

        // Declare class variables for calculations
        private decimal subtotal = 0m;
        private decimal salesTaxAmount = 0m;
        private decimal orderTotal = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display current date ( taken from system clock) in desired delivery date
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }


        private void homeDeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (homeDeliveryRadioButton.Checked)
                subtotal += HOME_DELIVERY_PRICE;
            subtotalValueLabel.Text = subtotal.ToString("c");
            salesTaxAmount = subtotal * SALES_TAX;
            salesTaxValueLabel.Text = salesTaxAmount.ToString("c");
            orderTotal = subtotal + salesTaxAmount;
        
            else
            { 
                subtotalValueLabel.Text = subtotal.ToString("c");
            salesTaxAmount = subtotal * SALES_TAX;
            salesTaxValueLabel.Text = salesTaxAmount.ToString("c");
            orderTotal = subtotal + salesTaxAmount;
        }
    }

    private void exitProgramButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to close?", "Infomate", MessageBoxButtons.YesNo) == DialogResult.No)
        {
            this.Close();
        }
    }

}
}



    
    

