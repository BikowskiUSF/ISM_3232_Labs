// Programmer: Remy Bikowski
// Project: Assignment 4
// Description: Hopkins film school class registration form
// Class: MainForm
// Class description: acts as main form of project, handles class registration
//                      calls AboutForm class when about button is clicked on






using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Add namespace to allow use of StreamReader and StreamWriter classes

namespace Bikowski_4
{
    public partial class RegistrationForm : Form
    {
        // Declare class constants for number of courses allowed
        private const decimal NUM_COURSES_ALLOWED = 4m;
        private const decimal LIVE_ACTION_COURSE_PRICE = 79.95m;
        private const decimal ANIMATION_COURSE_PRICE = 99.95m;
        private decimal current_price = 79.95m;



        public RegistrationForm()
        {
            InitializeComponent();
        }
        




        private void Form1_Load(object sender, EventArgs e)
        {
            // Display current date in registration date masked textbox
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            // call on custom method to populate list box
            PopulateList();

            // set number of courses availiable to be selected in label
            listBoxLabel.Text = "A maximum of " + NUM_COURSES_ALLOWED.ToString() + " courses is allowed";

            // Create array with status of registrant options
            string[] statusArray = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };
            

            // add array values to combo box        
                for (int i = 0; i < statusArray.Length; i++)
                {
                    statusComboBox.Items.Add(statusArray[i]);
      
                }
            // use update totals method to fill in form information
            updateTotals();

        }


        // Handle save button click event
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile; // Declare streamwriter object for use in writing summary file
            outputFile = File.AppendText("RegistrationData.Txt");
        }

        private void saveToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form (ending the program)
        }






        // Custom method to load data from external files into list box
        private void PopulateList()
        {
            try // Assure that input file specified is readable
            {
                StreamReader inputFile; // Declare StreamReader object for use in reading files

                if (liveActionRadioButton.Checked)
                {
                    classesListBox.Items.Clear();
                    inputFile = File.OpenText("LiveActionClasses.txt"); // Open file with live action classes list       
                    while (!inputFile.EndOfStream) // Verify that more data exists to be read
                    {
                        // Read a line from input file and add it to list box
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close(); // close the file after reading data
                }
                else if (animationRadioButton.Checked)
                {
                    classesListBox.Items.Clear();
                    inputFile = File.OpenText("AnimationClasses.txt"); // Open file with live action classes list
                    while (!inputFile.EndOfStream) // Verify that more data exists to be read
                    {
                        // Read a line from input file and add it to list box
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close(); // close the file after reading data
                }
            }
            catch (Exception ex)
            {
                // Display message if error occurs when attempting to read files
                MessageBox.Show(ex.Message);
                this.Close(); // Close the form (ending the program)
            }
        }

        // Handle check change event for live action radio
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (liveActionRadioButton.Checked)
                current_price = LIVE_ACTION_COURSE_PRICE;
                PopulateList();
                updateTotals();
        }

        // Handle check change event for animated radio button
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (animationRadioButton.Checked)
                current_price = ANIMATION_COURSE_PRICE;
                PopulateList();
            updateTotals();
        }

        // Custom method to update totals on form
        private void updateTotals()
        {
           numOfClassesValueLabel.Text = classesListBox.SelectedItems.Count.ToString();
            pricePerClassValueLabel.Text = current_price.ToString("c") ;
            totalPriceValueLabel.Text = (classesListBox.SelectedItems.Count * current_price).ToString();

        }



        private void classesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            updateTotals();

        }

        // Handle about menu item click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of the AboutForm class
            AboutBox1 myAboutForm = new AboutBox1();

            // Display AboutForm instance as a modal form
            myAboutForm.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            DOBMaskedTextBox.Text = "";
            statusComboBox.Text = "";
        }
    }    


            }

