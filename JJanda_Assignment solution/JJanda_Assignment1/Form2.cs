/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * Program Name: Assignment 2, Customer Form
 * Date: 9/23/15
 * ---------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace JJanda_Assignment1
{
    public partial class Form2 : Form
    {
        
        /// <summary>
        /// Form2 allows for the entry of Customer data and creates a customer object.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks string data and determines whether it contains a valid phone
        /// number. A valid number contains 10 digits. This method only validates 
        /// the number of digits. It does not format or remove additional characters
        /// or count non digit characters.
        /// </summary>
        /// <param name="pPhoneNumber">string data containing a phone number</param>
        /// <returns>true if valid number</returns>
        public bool ValidPhoneNumber(string pPhoneNumber)
        {
            //flag to determine if phone number is valid. Initialized to false.
            bool isValidPhoneNumber = false;
            
            //counter used to determine number of digits in an entry
            int counter = 0;

            //runs through the characters in the phone number string data
            //and counts the number of digits in the string.
            foreach (char c in pPhoneNumber)
            {
                //adds one to the counter each time a digit is found.
                if (char.IsDigit(c))
                    counter++;
            }
            //returns true if there are 10 digits in the string
            if (counter == 10)
                isValidPhoneNumber = true;

            return isValidPhoneNumber;
        }
       
        /// <summary>
        /// Creates a Customer object. Validates the phone number data 
        /// and prints an error message if an invalid number is entered.
        /// </summary>
        /// <param name="sender">Event handler argument</param>
        /// <param name="e">Event handler argument</param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //verifiies if the phone number is valid and prints an error message
            //if string does not contain 10 digits.
            if (!ValidPhoneNumber(textBoxPhoneNumber.Text))
            {
                //Error message display and clears phone number textbox.
                MessageBox.Show("Invalid phone number. Please enter a valid number.");
                textBoxPhoneNumber.Clear();
            }
            else
            {
                //creates a Customer object
                Customer myCustomer = new Customer(textBoxFirstName.Text,
                         textBoxLastName.Text, textBoxPhoneNumber.Text);

                //Displays the customer information in the message box label.
                labelInfoMessage.Text = myCustomer.ToString();
            }
        }

      
        /// <summary>
        /// Closes the Form and returns user to the Main Form
        /// </summary>
        /// <param name="sender">Click event argument</param>
        /// <param name="e">Click event argument</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
          Close();
        }

        /// <summary>
        /// Clears the Form
        /// </summary>
        /// <param name="sender">Click event argument</param>
        /// <param name="e">click event argument</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears the textboxes
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();

            //resets the message label to empty
            labelInfoMessage.Text = "";

            //returns focus to the first name textbox
            textBoxFirstName.Focus();
        }

    }


}
