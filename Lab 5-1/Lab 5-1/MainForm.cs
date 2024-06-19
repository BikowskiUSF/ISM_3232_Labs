// Programmer: Remy Bikowski
// Date: 04/11/2022
// Name: Lab 5-1
// Description: Ice cream calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab_5_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Use custome method to fill combo boxes
            PopulateBoxes();

            // Set default selection for combo box to vanilla
            flavorComboBox.SelectedItem = "Vanilla";
        }

        // Handle Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Write order info in output file
                StreamWriter outputFile; // use streamwriter object
                outputFile = File.AppendText("Orders.txt"); // specify file

                // Write current date in file
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

                // Determine cone type and write in file
                if (sugarConeRadioButton.Checked)
                {
                    outputFile.WriteLine("Sugar Cone");
                }
                else
                {
                    outputFile.WriteLine("Waffle Cone");
                }

                // write ice cream flavor selection in file
                outputFile.WriteLine(flavorComboBox.SelectedItem.ToString());

                // Loop through all items in list box and write selection to output file
                for (int count = 0; count < toppingsListBox.Items.Count; count++)
                {
                    // Use GetSelected method to see if item in list box is selected
                    if (toppingsListBox.GetSelected(count))
                    {
                        outputFile.WriteLine(toppingsListBox.Items[count]); // write to file
                    }
                }

                outputFile.WriteLine(); // Write a blank line to file
                outputFile.Close(); // Close output file after writing
            }
            catch (Exception ex)
            {
                // Display error message if error happens
                MessageBox.Show(ex.Message);
            }

            // Reset form to original appearance
            sugarConeRadioButton.Checked = true; // Select sugar cone radio button
            flavorComboBox.SelectedItem = "vanilla"; // set default selection for combo box
            toppingsListBox.ClearSelected(); // Clear anny topping selection
            sugarConeRadioButton.Focus(); // send focus to first date entry control on form
        }

        // Handle exit button event
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }
        // Custom method to load data from external files into combo and list boxes
        private void PopulateBoxes()
        {
            try // make sure input file is readable
            {
                StreamReader inputFile; // Declare StreamReader object

                inputFile = File.OpenText("Flavors.txt"); // open file with flavors
                while (!inputFile.EndOfStream) // check if there is more data to read
                {
                    // Read a line from input file and add it to combo box
                    flavorComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close(); // close input file after reading data

                inputFile = File.OpenText(toppingsLabel.Text); // open file with toppings
                while (!inputFile.EndOfStream)  // check if more data is to be read
                {
                    // Read line from input file and add it to list box
                    toppingsListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close(); // Close input file after reading data

            }
            catch (Exception ex)
            {
                // Display message if error occurs when reading files
                MessageBox.Show(ex.Message);
                this.Close(); // Close the form
            }




        }
    }
}
