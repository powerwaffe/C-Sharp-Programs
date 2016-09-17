﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validate_Two_Fields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Local variables
            int first, second, sum;

            if (int.TryParse(tbxFirst.Text, out first))
            {
                if (int.TryParse(tbxSecond.Text, out second))
                {
                    // Add the two numbers and display the sum.
                    sum = first + second;
                    MessageBox.Show(sum.ToString());
                }
                else
                {
                    // Display an error message about the second TextBox.
                    MessageBox.Show("The second TextBox contains invalid data.");
                }
            }
            else
            {
                // Display an error message about the first TextBox.
                MessageBox.Show("The first TextBox contains invalid data.");
            }
        }
    }
}
