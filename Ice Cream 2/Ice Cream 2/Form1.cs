using System;
using System.IO;
using System.Windows.Forms;

namespace Ice_Cream_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string flavor;

                // Open the data file for reading
                StreamReader inputFile = File.OpenText("C:\\Users\\Sean\\Source\\Repos\\C-Sharp-Programs\\Ice Cream\\Ice Cream\\bin\\Debug\\FlavorChoice.txt");

                // Read all the lines in the file
                while (!inputFile.EndOfStream)
                {
                    // Read the next line
                    flavor = inputFile.ReadLine();

                    // Add it to the list box
                    lbxIceCreamList.Items.Add(flavor);
                }
                // Close the file
                inputFile.Close();

                // Display the total amount of flavor selections
                lblEntries.Text = lbxIceCreamList.Items.Count + " flavor selections logged.";
            } // end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ice Cream Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            } // end catch
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Permanently delete this file's contents?",
                "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                // Delete all entries on file
                System.IO.File.WriteAllText("C:\\Users\\Sean\\Source\\Repos\\C-Sharp-Programs\\Ice Cream\\Ice Cream\\bin\\Debug\\FlavorChoice.txt",
                   string.Empty);

                // Set lblEntries counter to 0
                lblEntries.Text = 0 + " flavor selections logged.";

                // Clear list box contents
                lbxIceCreamList.Items.Clear();

                // Display verification 
                MessageBox.Show("Ice cream entries cleared");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit program
            Close();
        }
    }
}
