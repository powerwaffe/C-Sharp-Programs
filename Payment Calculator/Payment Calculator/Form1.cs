using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculateGrossPay_Click(object sender, EventArgs e)
        {
            decimal grossPay = decimal.Parse(tbHourlyPayRate.Text) * 
                decimal.Parse(tbHoursWorked.Text);
            MessageBox.Show("Gross Pay = " + grossPay.ToString("c"),
                "Wage Calculator");
        }
    }
}
