using System;
using System.Windows.Forms;

namespace Tutorial_5_8
{
    public partial class Form1 : Form
    {
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
            }
            else
            {
                // Display tails
                pbxHeads.Visible = false;
                pbxTails.Visible = true;
            }
        }
    }
}
