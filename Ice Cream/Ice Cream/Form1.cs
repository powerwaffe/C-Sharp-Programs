using System;
using System.IO;
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
            try
            {
                string flavor;

                //Open the data file for reading
                StreamReader inputFile = File.OpenText("flavors.txt");

                //Read all the lines in the file
                while (!inputFile.EndOfStream)
                {
                    //Read the next line
                    flavor = inputFile.ReadLine();

                    //Add it to the list box
                    lbxFlavors.Items.Add(flavor);
                }
                //Close the file
                inputFile.Close();

                //Display the number of flavors
                lblFlavors.Text = lbxFlavors.Items.Count + " flavors available today";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ice Cream Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }


           /* lbxFlavors.Items.Add("Vanilla");
            lbxFlavors.Items.Add("Chocolate");
            lbxFlavors.Items.Add("Strawberry");
            lbxFlavors.Items.Add("Fear Sundae");
            lbxFlavors.Items.Add("Denim");
            lbxFlavors.Items.Add("Mango");*/
        }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = lbxFlavors.SelectedItem.ToString();
        }
    }
}
