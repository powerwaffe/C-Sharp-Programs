using System;
using System.Windows.Forms;

namespace Pet_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayPet_Click(object sender, EventArgs e)
        {
            // Create pet object
            Pet myPet = new Pet();

            // Temp variable for TryParse
            int petAge;

            if (tbxPetName.Text.Length > 0)
            {
                // Get pet's name
                myPet.Name = tbxPetName.Text;
                if (tbxPetType.Text.Length > 0)
                {
                    // Get pet's type
                    myPet.Type = tbxPetType.Text;
                    if (int.TryParse(tbxPetAge.Text, out petAge))
                    {
                        // Get pet's age
                        myPet.Age = petAge;

                        // Display Pet
                        MessageBox.Show("Your pet's name is " + myPet.Name + " and is a " + myPet.Type +
                        " that is about " + myPet.Age + " years old.", "Pet Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Display error
                        MessageBox.Show("Warning, Invalid entry for pet age!", "Pet Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display error
                    MessageBox.Show("Warning, invalid entry for pet type!", "Pet Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display error
                MessageBox.Show("Warning, invalid entry for pet name!", "Pet Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearPet_Click(object sender, EventArgs e)
        {
            tbxPetName.Text = "";
            tbxPetType.Text = "";
            tbxPetAge.Text = "";

            MessageBox.Show("Clearing entries", "Pet Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
