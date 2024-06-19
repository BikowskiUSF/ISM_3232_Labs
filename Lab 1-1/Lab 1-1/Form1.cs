// Programmer: Remy Bikowski
// Project: Lab 1-1
// Date: 01/21/2022
// Description: Displays a greeting to user.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        // Display greeting in message box
        private void greetingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + firstNameTextBox.Text + "! Welcome to my program!");
        }

        // Close form (ending program)
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
