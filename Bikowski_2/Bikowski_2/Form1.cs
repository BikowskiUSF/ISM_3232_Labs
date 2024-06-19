// Programmer: Remy Bikowski
// Project: Bikowski_2
// Due Date: 02/25/2022
// Description: Individual Assignment #2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikowski_2
{
    public partial class orderForm : Form
    {
        // Declare local constants
        const decimal IN_STATE_PRICE = 49.00m;
        const decimal OUT_OF_STATE_PRICE = 99.00m;
        // Declare local variables
        decimal pricePerCourse = IN_STATE_PRICE;
        int coursesSelected = 0;
        decimal totalPrice = 0;
        public orderForm()
        {
            InitializeComponent();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {

        }

        private void inStateResidencyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inStateResidencyButton.Checked)
            {
                pricePerCourse = IN_STATE_PRICE;
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }
            else
            {
                pricePerCourse = OUT_OF_STATE_PRICE;
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }


        }

        // Handle number of courses displayed in label
        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(frenchCheckBox.Checked)
            {
                coursesSelected += 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }
            else
                coursesSelected -= 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
        }

        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(germanCheckBox.Checked)
            {
                coursesSelected += 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }
            else
                coursesSelected -= 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
        }

        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(italianCheckBox.Checked)
            {
                coursesSelected += 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }
            else
                coursesSelected -= 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
        }

        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(spanishCheckBox.Checked)
            {
                coursesSelected += 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }
            else
                coursesSelected -= 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
        }

        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(russianCheckBox.Checked)
            {
                coursesSelected += 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
            }
            else
                coursesSelected -= 1;
                numberOfCoursesBox.Text = coursesSelected.ToString();
                totalPrice = coursesSelected * pricePerCourse;
                totalPriceBox.Text = totalPrice.ToString("c");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (coursesSelected <= 3 && coursesSelected >= 1)
            {
                MessageBox.Show("Registration Term " + termYearComboBox.Text + "\n" +

                "Student ID: " + studentIDMaskedTextbox.Text + " " + "\n" +

                "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +

                "Email Address: " + emailTextBox.Text + "\n" + "Total Courses Purchased:" +
                coursesSelected + "\n" + "Price per course:" + pricePerCourse + "\n" + 
                "Total Order Price:" + totalPrice + "\n" + "Card Number:" + creditCardMaskedTextBox.Text
                + "\n" + "Expiration Date:" + expirationDateMaskedTextBox.Text);
            }
            else
            {
                MessageBox.Show("In order to save your invoice, you must select between 1 and 3 courses!");
            }
        }
        // Execute the clear button click event
        private void clearButton_Click(object sender, EventArgs e)
        {
            fallTermRadioButton.Checked = true;
            termYearComboBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            studentIDMaskedTextbox.Text = "";
            emailTextBox.Text = "";
            inStateResidencyButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            russianCheckBox.Checked = false;

            // Change focus to term year combo box
            termYearComboBox.Focus();

        }
        //Execute exit button event
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
            
        }
      

