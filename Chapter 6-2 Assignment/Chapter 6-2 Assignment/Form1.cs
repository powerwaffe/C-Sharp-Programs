using System;
using System.Windows.Forms;

namespace Chapter_6_2_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcAverage_Click(object sender, EventArgs e)
        {
            // Variables
            double grade1 = 0, grade2 = 0, average = 0;

            if (isInputValid(ref grade1, ref grade2))
            {
                // Calculate and print to text box
                average = (grade1 + grade2) / 2;
                tbxAverage.Text = average.ToString("#.##");
            }
        }

        private bool isInputValid(ref double grade1, ref double grade2)
        {
            // Flag variable to indicate if input is good or not
            bool inputGood = false;

            if (double.TryParse(tbxGrade1.Text, out grade1))
            {
                if (double.TryParse(tbxGrade2.Text, out grade2))
                {
                    inputGood = true;
                    if (grade2 >= 0 && grade2 <= 100)
                    {
                        //return true;
                        if (grade1 >= 0 && grade1 <= 100)
                        {
                            // Variables are within parameters return true
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Grade 1 is out of range", "Average", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Grade 2 is out of range", "Average", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Grade 2 is invalid", "Average", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Grade 1 is invalid", "Average", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // Return result
            return inputGood;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxGrade1.Text = "";
            tbxGrade2.Text = "";
            tbxAverage.Text = "";
        }
    }
}
