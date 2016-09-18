using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double miles;   // To hold miles driven
                double gallons; // To hold gallons used
                double mpg;     // To hold MPG

                // Get the miles driven and assign it to the miles variable
                miles = double.Parse(tbxMilesDriven.Text);

                // Get the gallons driven and assign it to the gallons variable
                gallons = double.Parse(tbxGallonsUsed.Text);

                // Calculate the MPG
                mpg = miles / gallons;

                // Display the MPg in the lblMPG control
                lblMPG.Text = mpg.ToString();
            }


            catch (Exception ex)
            {
                // Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
