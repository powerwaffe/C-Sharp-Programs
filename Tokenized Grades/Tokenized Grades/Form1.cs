using System;
using System.Windows.Forms;
using System.IO;

namespace Tokenized_Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetScores_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFIle; // To read the file
                string line;            // To hold a line from the file
                int count = 0;          // Student counter
                int total;              // Accumulator
                double average;         // Test score average

                // Create a delimeter array
                char[] delim = { ',' };

                // Open the grades file
                inputFIle = File.OpenText("grades.txt");

                while (!inputFIle.EndOfStream)
                {
                    // Increment the student counter
                    count++;

                    // Read a line from the file
                    line = inputFIle.ReadLine();

                    // Get the test scores as tokens
                    string[] tokens = line.Split(delim);

                    // Set the accumulator to 0
                    total = 0;

                    // Calculate the total of the test score tokens
                    foreach (string str in tokens)
                        total += int.Parse(str);

                    // Calculate the average of these test scores
                    average = (double)total / tokens.Length;

                    // Display the average
                    lbxScores.Items.Add("The average for student " + count + " is " +
                        average.ToString("n1"));
                }

                // Close the file
                inputFIle.Close();
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
