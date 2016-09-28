using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Program_6_1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCalcAverage_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                MessageBox.Show("Got valid input", "Average", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private bool isInputValid()
        {
            double exam1, exam2;
             if (double.TryParse(tbxExam1.Text, out exam1))
             {
                if (exam1 >= 0 && exam1 <= 100)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Exam 1 is out of range", "Average", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return false;
                }
             }
             else
            {
                MessageBox.Show("Exam 1 missing or not numberic", "Average", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
