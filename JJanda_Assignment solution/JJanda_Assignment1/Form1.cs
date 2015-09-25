/*
 * --------------------------------------------------------------------------
 * Developer: Jeff Janda
 * Program Name: Assignment 1, Pizza Shop
 * Date: 8/31/15
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

namespace JJanda_Assignment1
{
    /// <summary>
    /// PizzaShop class Form control takes in user input from a TextBox control
    /// and print a Label Control message stating how many pizzas were ordered
    /// by the user. Input is validated using the TryParse method and passing the
    /// out int variable pizzaNumber reference to the Label message. Non int
    /// user input is assigned a value of 0.
    /// 
    /// Users are provided three Button controls; Order, Clear, and Exit.
    /// Order will print the Label Control message. Clear will clear the message
    /// and value in the Textbox. Exit will close the program. 
    /// 
    /// In addition to the Controls above, there are several Label controls which
    /// are used provide orientation for the user through the GUI. 
    /// </summary>
    
   
    public partial class PizzaShop : Form
    {
        
        public PizzaShop()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------
         * Click event handler for buttonOrder control.
         * This method takes input from the txtBoxPizzaNumber 
         * control and prints a message in the labelMessage control
         * stating the number of Pizzas a user has ordered. This 
         * method also clears the txtBoxPizzaNumber control
         * --------------------------------------------------------
         */
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            //holds the value for number of pizzas ordered
            int pizzaNumber = 0; 

           
            /*----------------------------------------------------
             * TryParse method is being used here to provide a
             * simple input validation by taking the value of
             * the txtBoxPizzaNumber and assigning it to 
             * the pizzaNumber variable if true. If false
             * pizzaNumber remains equal to 0. 
             * 
             * Prevents a logical error where a user enters a value
             * other than an a number. 
             *----------------------------------------------------- 
             */
            int.TryParse(txtBoxPizzaNumber.Text, out pizzaNumber);

            //Conditional statement for pizza orders greater than 1.
            if (pizzaNumber > 1)
            {   
                //Order message for multiple pizzas.
                labelOrderMessage.Text = "You ordered " + pizzaNumber + " pizzas. "
                    + "Your order will be ready shortly.";
            }
            //Conditional statement for pizza orders equal to 1.
            else if (pizzaNumber == 1)
            {
                //Order message for a single pizza.
                labelOrderMessage.Text = "You ordered " + pizzaNumber + " pizza. "
                + "Your order will be ready shortly.";
            }
            //conditional statement for orders of 0 or non int values.
            else if (pizzaNumber == 0)
            {
                //Order message for 0 or non nummeric orders.
                labelOrderMessage.Text = "You didn't order any pizzas.";
            }

            //clears the txtBoxPizzaNumber control.
            txtBoxPizzaNumber.Text = "";
        }
        /*------------------------------------------------------------
         * Click event handler for buttonClear control.
         * This method clears the value from the textBoxPizzaNumber
         * and the pizza order message.
         * -----------------------------------------------------------
         */
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelOrderMessage.Text = ""; //clears the order message

            txtBoxPizzaNumber.Text = ""; //clears the Textbox control
        }
        /*------------------------------------------------------------
         * Click event handler for the buttonExit control.
         * This method calls the Form Close() and exits the program.
         * -----------------------------------------------------------
         */
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for customer button
        /// </summary>
        /// <param name="sender">click event parameter</param>
        /// <param name="e">click event parameter</param>
        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            //creates a new Form2 object reference
            Form2 customerForm = new Form2();
            
            //opens a Form2
            customerForm.ShowDialog();
        }
    }
}
