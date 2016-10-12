using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink_Vending_Machine
{
    // Structure of vending machine variables
    struct Soda
    {
        public string drinkName;
        public double drinkCost;
        public int numberOfDrinksInMachine;
    }
    public partial class Form1 : Form
    {
        // Declare and initialize an array of structure type
        Soda[] soda = new Soda[5];

        // Subtotal for drinks
        double subtotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbxCola_Click(object sender, EventArgs e)
        {
            // Set drink name
            soda[0].drinkName = "Cola";

            // Increment subtotal
            soda[0].drinkCost = 1.00;
            subtotal += soda[0].drinkCost;

            // Decrement number of cola
            soda[0].numberOfDrinksInMachine = int.Parse(lblColaRemaining.Text) - 1;

            if (int.Parse(lblColaRemaining.Text) > 0)
            {
                // Print drinks to labels
                lblColaRemaining.Text = soda[0].numberOfDrinksInMachine.ToString();
                lblTotalSales.Text = subtotal.ToString("c");
            }
            else
            {
                // No more soda, print message
                MessageBox.Show("Sold out of " + soda[0].drinkName, "Vending Machine");
            }
        }

        private void pbxRootBeer_Click(object sender, EventArgs e)
        {
            // Set drink name
            soda[1].drinkName = "Root Beer";

            // Increment subtotal
            soda[1].drinkCost = 1.00;
            subtotal += soda[1].drinkCost;

            // Decrement number of cola
            soda[1].numberOfDrinksInMachine = int.Parse(lblRootBeerRemaining.Text) - 1;

            if (int.Parse(lblRootBeerRemaining.Text) > 0)
            {
                // Print drinks to labels
                lblRootBeerRemaining.Text = soda[1].numberOfDrinksInMachine.ToString();
                lblTotalSales.Text = subtotal.ToString("c");
            }
            else
            {
                // No more soda, print message
                MessageBox.Show("Sold out of " + soda[1].drinkName, "Vending Machine");
            }
        }

        private void pbxLemonLime_Click(object sender, EventArgs e)
        {
            // Set drink name
            soda[2].drinkName = "Lemon Lime";

            // Increment subtotal
            soda[2].drinkCost = 1.00;
            subtotal += soda[2].drinkCost;

            // Decrement number of cola
            soda[2].numberOfDrinksInMachine = int.Parse(lblLemonLimeRemaining.Text) - 1;

            if (int.Parse(lblLemonLimeRemaining.Text) > 0)
            {
                // Print drinks to labels
                lblLemonLimeRemaining.Text = soda[2].numberOfDrinksInMachine.ToString();
                lblTotalSales.Text = subtotal.ToString("c");
            }
            else
            {
                // No more soda, print message
                MessageBox.Show("Sold out of " + soda[2].drinkName, "Vending Machine");
            }
        }

        private void pbxGrapeSoda_Click(object sender, EventArgs e)
        {
            // Set drink name
            soda[3].drinkName = "Grape Soda";

            // Increment subtotal
            soda[3].drinkCost = 1.50;
            subtotal += soda[3].drinkCost;

            // Decrement number of cola
            soda[3].numberOfDrinksInMachine = int.Parse(lblGrapeSodaRemaining.Text) - 1;

            if (int.Parse(lblGrapeSodaRemaining.Text) > 0)
            {
                // Print drinks to labels
                lblGrapeSodaRemaining.Text = soda[3].numberOfDrinksInMachine.ToString();
                lblTotalSales.Text = subtotal.ToString("c");
            }
            else
            {
                // No more soda, print message
                MessageBox.Show("Sold out of " + soda[3].drinkName, "Vending Machine");
            }
        }

        private void pbxCreamSoda_Click(object sender, EventArgs e)
        {
            // Set drink name
            soda[4].drinkName = "Cream Soda";

            // Increment subtotal
            soda[4].drinkCost = 1.50;
            subtotal += soda[4].drinkCost;

            // Decrement number of cola
            soda[4].numberOfDrinksInMachine = int.Parse(lblCreamSodaRemaining.Text) - 1;

            if (int.Parse(lblCreamSodaRemaining.Text) > 0)
            {
                // Print drinks to labels
                lblCreamSodaRemaining.Text = soda[4].numberOfDrinksInMachine.ToString();
                lblTotalSales.Text = subtotal.ToString("c");
            }
            else
            {
                // No more soda, print message
                MessageBox.Show("Sold out of " + soda[4].drinkName, "Vending Machine");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
