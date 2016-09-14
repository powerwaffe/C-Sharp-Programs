using System;
using System.Windows.Forms;

namespace Tutorial_5_8
{
    public partial class Form1 : Form
    {
        // Initialize heads and tails counters/percentages
        int headsCounter = 0;
        int tailsCounter = 0;
        double headsPercent = 0;
        double tailsPercent = 0;
        int numOfFlips = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            // Create random object with time base seed
            Random rand = new Random();

            // Toss the coin
            int toss = rand.Next(2);

            // Dispaly the results
            if (toss == 0)
            {
                // Display heads
                pbxHeads.Visible = true;
                pbxTails.Visible = false;

                // Increament heads
                headsCounter++;
                numOfFlips++;
                tbxNumOfHeads.Text = headsCounter.ToString();
            }
            else
            {
                // Display tails
                pbxHeads.Visible = false;
                pbxTails.Visible = true;

                // Increment tails
                tailsCounter++;
                numOfFlips++;
                tbxNumOfTails.Text = tailsCounter.ToString();
            }
            // Calculate percentahes of sides
            tailsPercent = (1.0 * tailsCounter / numOfFlips) * 100;
            headsPercent = (1.0 * headsCounter / numOfFlips) * 100;

            // Display 
            tbxPercentOfHeads.Text = headsPercent.ToString("#.##");
            tbxPercentOfTails.Text = tailsPercent.ToString("#.##");
            
        }

        private void tbxNumOfHeads_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
