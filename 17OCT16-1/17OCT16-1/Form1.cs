using System;
using System.Windows.Forms;

namespace _17OCT16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            Pet myDog = new Pet();
            myDog.Name = "Rover";
            MessageBox.Show("Youre dog's name is " +  myDog.Name, "Pet Names",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Pet myCat = new Pet();
            myCat.Name = "Cornelius";
            MessageBox.Show("Youre cat's name is " + myCat.Name, "Pet Names",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
