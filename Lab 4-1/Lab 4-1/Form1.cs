// Programmer: Remy Bikowski
// Project: Lab 4-1
// Date: 03/25/2022
// Description: Real Estate Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // add to allow use of StreamWriter

namespace Lab_4_1
{
    public partial class Form1 : Form
    {
        // Declare class constants for tax and commision rate
        private const decimal STATE_SALES_TAX_RATE = 0.06m;
        private const decimal HILLSBOROUGH_SALES_TAX_RATE = 0.01m;
        private const decimal PASCO_SALES_TAX_RATE = 0m;
        private const decimal POLK_SALES_TAX_RATE = 0.005m;
        private const decimal RESIDENTIAL_COMMISION_RATE = 0.06m;
        private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;

        // Declare class variables for calculations of totals
        private decimal propertyPrice = 0m;
        private decimal stateSalesTax = 0m;
        private decimal countySalesTax = 0m;
        private decimal commission = 0m;
        private decimal totalPrice = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display current date ( taken from system clock) in sale date textbox
            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Disable save button until price textbox has value greater than zero
            saveButton.Enabled = false;
        }

        // Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            try // Write data to external text file
            {
                StreamWriter outputFile; // Declare StreamWriter for writing file
                outputFile = File.AppendText("Properties.txt"); // file to write to
                // Write all inputed data to file
                outputFile.WriteLine("Date: " + saleDateMaskedTextBox.Text);
                outputFile.WriteLine("Property Price: " + propertyPrice.ToString("c"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("c"));
                outputFile.WriteLine("Country Sales Tax: " + countySalesTax.ToString("c"));
                outputFile.WriteLine("Commission: " + commission.ToString("c"));
                outputFile.WriteLine("Total Price: " + totalPrice.ToString("c"));
                outputFile.WriteLine(); // blank line (to seperate properties)
                outputFile.Close(); // Close output file after writing data

                MessageBox.Show("Data successfully saved to file.", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); //Show confirmation msg

                ClearForm();  // Clears form
            }

            catch (Exception ex)
            {
                // Display message if error happens when writing file
                MessageBox.Show(ex.Message);
            }
        }

        // Clear button click event
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm(); // clear form
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // end the program
            this.Close();
        }





        // Residential radio button check changed event
        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Use custom method to update calculated totals
        }


        // Hillsborough radio button check changed event
        private void hillsboroughRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Use custom method to update calculated totals
        }

        // Paco radio button check changed event
        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // use custom method to update calculated totals
        }

        // Property price text box text input change event
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = false; // Disables save button UpdateTotals method enables)
        }



        // Update Price button click event
        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateTotals(); // Use custom method to update calculated totals
            saveButton.Focus(); // send focus to save button
        }

        // Define custopm method to update total fields
        private void UpdateTotals()
        {
            // Read price entered by user
            // TryParse used to handle nonsense entries
            if (decimal.TryParse(priceTextBox.Text, out propertyPrice))
            {
                // Set price variable to text property of priceTextBox
                propertyPrice = decimal.Parse(priceTextBox.Text);

                // Calculate state sales tax
                stateSalesTax = propertyPrice * STATE_SALES_TAX_RATE;

                // Calculate county sale tax based on chosen country
                if (hillsboroughRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBOROUGH_SALES_TAX_RATE;
                }
                else if (pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;
                }
                else if (polkRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * POLK_SALES_TAX_RATE;
                }

                // Calculate commission based on property type
                if (residentialRadioButton.Checked)
                {
                    commission = propertyPrice * RESIDENTIAL_COMMISION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;
                }
            }
            // Calc total price
            totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

            // Format and show calculated values as currency
            stateTaxValueLabel.Text = stateSalesTax.ToString("c");
            countyTaxValueLabel.Text = countySalesTax.ToString("c");
            commissionValueLabel.Text = commission.ToString("c");
            totalPriceValueLabel.Text = totalPrice.ToString("c");

            if (propertyPrice > 0) // Check that a price greater than 0 is inputted
            {
                saveButton.Enabled = true; // enables save button
            }

            else // if nonsense value is entered for property price
            {
                MessageBox.Show("You must enter a numeric value for Property Price." +
                    "\nEnter digits only (no dollar sign) for Property Price.",
                    "Blank Value or Non-Numeric Character Entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                priceTextBox.Focus(); // Sends focus to property price text box
            }
        }

        // Custom method to clear form
        private void ClearForm()
        {
            // Clear controls and reset form to original state
            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillsboroughRadioButton.Checked = true;
            priceTextBox.Text = "0.00";
            stateTaxValueLabel.Text = "$0.00";
            countyTaxValueLabel.Text = "$0.00";
            commissionValueLabel.Text = "$0.00";
            totalPriceValueLabel.Text = "$0.00";
            saveButton.Enabled = false; // Disable save button (until UpdateTotals method runs)
            priceTextBox.Focus(); // set focus to property price textbox
        }
    }
}
