using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Cream
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxFlavors.Items.Add("Vanilla");
            lbxFlavors.Items.Add("Chocolate");
            lbxFlavors.Items.Add("Strawberry");
            lbxFlavors.Items.Add("Fear Sundae");
            lbxFlavors.Items.Add("Denim");
            lbxFlavors.Items.Add("Mango");
        }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = lbxFlavors.SelectedItem.ToString();
        }
    }
}
