using System;
using System.Windows.Forms;

namespace Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculateGrossPay_Click(object sender, EventArgs e)
        {
            try
            {
                /*Calculate gross pay when user enters numeric value into text box*/
                decimal grossPay = decimal.Parse(tbHourlyPayRate.Text) *
                    decimal.Parse(tbHoursWorked.Text);
                tbCalculatedGrossPay.Text= grossPay.ToString("c");
            }
            catch
            {
                //Display Error
                MessageBox.Show("Warning: Data must be in numeric form.");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear textboxes for wage calculator
            //String.Empty; - Provides similar results
            tbHourlyPayRate.Text = "";
            tbHoursWorked.Text = "";
            tbCalculatedGrossPay.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close program
            Close();
        }
    }
}
