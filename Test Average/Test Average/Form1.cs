using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class btnExit : Form
    {
        public btnExit()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare constant that cant change
                const double HIGH_SCORE = 95.0;

                // Variables to hold test scores and average
                double test1, test2, test3, average;

                // Get the three test scores
                test1 = double.Parse(tbxTest1.Text);
                test2 = double.Parse(tbxTest2.Text);
                test3 = double.Parse(tbxTest3.Text);

                // Calculate the average test score with the output 
                // rounded to 1 decimal point
                average = (test1 + test2 + test3) / 3.0;

                // Display the average test score with the output rounded
                // to 1 decimal point
                lblAverage.Text = average.ToString("n1");

                // If the average is a high score congratualte the
                // user with a message box
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations, you have a high score!");
                }
            }
            catch (Exception ex)
            {
                // Display default error messaage
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxTest1.Text = "";
            tbxTest2.Text = "";
            tbxTest3.Text = "";
            lblAverage.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
