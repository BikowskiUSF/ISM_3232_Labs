// Programmer: Remy Bikowski
// Project: Bikowski_1
// Due Date: 02/11/2022
// Decription: Individual Assignment #1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikowski_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            // Use Try-Catch to handle any exceptions
            try
            {
                // Declare local constants
                const decimal TAX_RATE = 0.07m;

                //Declare local variables
                int roomNumber;  // Room number
                int lengthOfStay; // Number of nights in hotel
                decimal nightlyRate; // Price per night
                decimal miniBarCharge; // Charges for mini bar
                decimal telephoneCharge; // Charge for using phone
                decimal miscCharge; // Miscellaneous charges
                decimal roomCharge; //Charge for room
                decimal additionalCharge; // Additional charge for room
                decimal subtotal; // Subtotal
                decimal taxAmount; // Tax charge
                decimal totalCharge; // Total Charges for hotel

                // Get values from input data and assign to variables
                roomNumber = int.Parse(roomNumberMaskedBox);
                lengthOfStay = int.Parse(lengthOfStayTextBox);
                nightlyRate = decimal.Parse(nightlyRateTextBox);
                miniBarCharge = decimal.Parse(miniBarChargeTextBox);
                telephoneCharge = decimal.Parse(telephoneCharge);
                miscCharge = decimal.Parse(miscChargeTextBox);


                // Calculate total charges based on inputs
                roomCharge = lengthOfStay * nightlyRate;
                additionalCharge = miniBarCharge + telephoneCharge + miscCharge;
                subtotal = roomCharge + additionalCharge;
                taxAmount = subtotal * TAX_RATE;
                totalCharge = subtotal + taxAmount;

                // Display total charges based on inputs
                roomChargeOutputBox.Text = roomCharge.ToString("c");
            }




            catch (Exception ex)
            {
                // Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalChargesOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
