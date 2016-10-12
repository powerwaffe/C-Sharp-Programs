using System;
using System.Drawing;
using System.Windows.Forms;

namespace Common_Handler
{
    public partial class Form1 : Form
    {
        // Declare a global array
        Button[] floorButtons;

        public Form1()
        {
            InitializeComponent();

            // Load the buttons into the array
            floorButtons = new Button[]
            {
                btnFloor1, btnFloor2, btnFloor3, btnFloor4, btnFloor5,
                btnFloor6, btnFloor7, btnFloor8, btnFloor9, btnFloor10
            };

            // Set the initial color
            foreach (Button item in floorButtons)
                item.BackColor = Color.White;
        }

        // This is the common handler for all the floor buttons
        // Note there are 10 references to it
        private void btnFloor_Click(object sender, EventArgs e)
        {
            // Note the parenthesis are required to cast the sender to a button object
            ((Button)sender).BackColor = Color.Pink;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Button item in floorButtons)
                item.BackColor = Color.White;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            foreach (Button item in floorButtons)
                item.BackColor = Color.Pink;
        }
    }
}