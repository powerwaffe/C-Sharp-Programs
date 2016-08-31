using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        //Constants
        const decimal appleValue = 80;
        const decimal pearValue = 120;
        const decimal bananaValue = 115;
        const decimal orangeValue = 90;

        //Total calories
        private decimal total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbBanana_Click(object sender, EventArgs e)
        {
           // lbCalories.Text = "115";
            total += bananaValue;
            lbCalories.Text = total.ToString();
        }

        private void pbApple_Click(object sender, EventArgs e)
        {
            //lbCalories.Text = "80";
            total += appleValue;
            lbCalories.Text = total.ToString();
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {
            //lbCalories.Text = "90";
            total += orangeValue;
            lbCalories.Text = total.ToString();
        }

        private void pbPear_Click(object sender, EventArgs e)
        {
            //lbCalories.Text = "120";
            total += pearValue;
            lbCalories.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            lbCalories.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
