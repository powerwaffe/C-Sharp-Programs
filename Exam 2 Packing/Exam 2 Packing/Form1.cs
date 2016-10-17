using System;
using System.Drawing;
using System.Windows.Forms;

// Did not utilize all methods as specified in schematic. Only method utilized is EmptyBox.
// Although long and clunky, program produces same results. Would like to modularize code far
// better than presented.
namespace Exam_2_Packing
{
    public partial class Form1 : Form
    {
        // Global array of picture boxes
        PictureBox[] boxes;
        public Form1()
        {
            InitializeComponent();

            // Initialize and load picutre boxes into array
            boxes = new PictureBox[]
            {
                pbxBox1, pbxBox2, pbxBox3, pbxBox4, pbxBox5,
                pbxBox6, pbxBox7, pbxBox8
            };

            // Set the initial color
            foreach (PictureBox item in boxes)
                item.BackColor = Color.Wheat;
        }

        // Empty contents of box
        public void EmptyBox()
        {
            // Remove all boxes and set back to original color
            foreach (PictureBox item in boxes)
                item.BackColor = Color.Wheat;
        }

        // Finds first empty slot in box
        // NOTE: Not implemented into final program
        public int FindFirstEmptySlot()
        {
            int myIndex = 0;
            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].BackColor == Color.Wheat)
                {
                    myIndex = i;
                    return myIndex;
                }
            }
            return myIndex;
        }

        private void btnEmptyBox_Click(object sender, EventArgs e)
        {
            // Clear contents of box
            EmptyBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close program
            Close();
        }

        private void btnShipBox_Click(object sender, EventArgs e)
        {
            // Remove all boxes and set back to original color
            EmptyBox();

            // Display alter that contents have been shipped
            MessageBox.Show("Shipping contents of box", "We Pack 'Em");
        }

        private void pbxRedShippingBox_Click(object sender, EventArgs e)
        {
            // Check if color of picture box is wheat, if it is add color
            foreach (PictureBox item in boxes)
            {
                if (pbxBox1.BackColor == Color.Wheat)
                {
                    pbxBox1.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox2.BackColor == Color.Wheat)
                {
                    pbxBox2.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox3.BackColor == Color.Wheat)
                {
                    pbxBox3.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox4.BackColor == Color.Wheat)
                {
                    pbxBox4.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox5.BackColor == Color.Wheat)
                {
                    pbxBox5.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox6.BackColor == Color.Wheat)
                {
                    pbxBox6.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox7.BackColor == Color.Wheat)
                {
                    pbxBox7.BackColor = Color.Red;
                    break;
                }
                else if (pbxBox8.BackColor == Color.Wheat)
                {
                    pbxBox8.BackColor = Color.Red;
                    break;
                }
                else
                {
                    MessageBox.Show("Cannot add anymore pieces to box!", "We Pack 'Em");
                    break;
                }
            }
        }

        private void pbxGreenShippingBox_Click(object sender, EventArgs e)
        {
            // Check if color of picture box is wheat, if it is add color
            foreach (PictureBox item in boxes)
            {
                if (pbxBox1.BackColor == Color.Wheat && pbxBox2.BackColor == Color.Wheat)
                {
                    pbxBox1.BackColor = Color.Green;
                    pbxBox2.BackColor = Color.Green;
                    break;
                }
                else if (pbxBox2.BackColor == Color.Wheat && pbxBox3.BackColor == Color.Wheat)
                {
                    pbxBox2.BackColor = Color.Green;
                    pbxBox3.BackColor = Color.Green;
                    break;
                }
                else if (pbxBox3.BackColor == Color.Wheat && pbxBox4.BackColor == Color.Wheat)
                {
                    pbxBox3.BackColor = Color.Green;
                    pbxBox4.BackColor = Color.Green;
                    break;
                }
                else if (pbxBox4.BackColor == Color.Wheat && pbxBox5.BackColor == Color.Wheat)
                {
                    pbxBox4.BackColor = Color.Green;
                    pbxBox5.BackColor = Color.Green;
                    break;
                }
                else if (pbxBox5.BackColor == Color.Wheat && pbxBox6.BackColor == Color.Wheat)
                {
                    pbxBox5.BackColor = Color.Green;
                    pbxBox6.BackColor = Color.Green;
                    break;
                }
                else if (pbxBox6.BackColor == Color.Wheat && pbxBox7.BackColor == Color.Wheat)
                {
                    pbxBox6.BackColor = Color.Green;
                    pbxBox7.BackColor = Color.Green;
                    break;
                }
                else if (pbxBox7.BackColor == Color.Wheat && pbxBox8.BackColor == Color.Wheat)
                {
                    pbxBox7.BackColor = Color.Green;
                    pbxBox8.BackColor = Color.Green;
                    break;
                }
                else
                {
                    MessageBox.Show("Cannot add anymore pieces to box!", "We Pack 'Em");
                    break;
                }
            }
        }

        private void pbxBlueShippingBox_Click(object sender, EventArgs e)
        {
            // Check if color of picture box is wheat, if so add color
            foreach (PictureBox item in boxes)
            {
                if (pbxBox1.BackColor == Color.Wheat && pbxBox2.BackColor == Color.Wheat &&
                    pbxBox3.BackColor == Color.Wheat)
                {
                    pbxBox1.BackColor = Color.Blue;
                    pbxBox2.BackColor = Color.Blue;
                    pbxBox3.BackColor = Color.Blue;
                    break;
                }
                else if (pbxBox2.BackColor == Color.Wheat && pbxBox3.BackColor == Color.Wheat &&
                    pbxBox4.BackColor == Color.Wheat)
                {
                    pbxBox2.BackColor = Color.Blue;
                    pbxBox3.BackColor = Color.Blue;
                    pbxBox4.BackColor = Color.Blue;
                    break;
                }
                else if (pbxBox3.BackColor == Color.Wheat && pbxBox4.BackColor == Color.Wheat &&
                    pbxBox5.BackColor == Color.Wheat)
                {
                    pbxBox3.BackColor = Color.Blue;
                    pbxBox4.BackColor = Color.Blue;
                    pbxBox5.BackColor = Color.Blue;
                    break;
                }
                else if (pbxBox4.BackColor == Color.Wheat && pbxBox5.BackColor == Color.Wheat &&
                    pbxBox6.BackColor == Color.Wheat)
                {
                    pbxBox4.BackColor = Color.Blue;
                    pbxBox5.BackColor = Color.Blue;
                    pbxBox6.BackColor = Color.Blue;
                    break;
                }
                else if (pbxBox5.BackColor == Color.Wheat && pbxBox6.BackColor == Color.Wheat &&
                    pbxBox7.BackColor == Color.Wheat)
                {
                    pbxBox5.BackColor = Color.Blue;
                    pbxBox6.BackColor = Color.Blue;
                    pbxBox7.BackColor = Color.Blue;
                    break;
                }
                else if (pbxBox6.BackColor == Color.Wheat && pbxBox7.BackColor == Color.Wheat &&
                    pbxBox8.BackColor == Color.Wheat)
                {
                    pbxBox6.BackColor = Color.Blue;
                    pbxBox7.BackColor = Color.Blue;
                    pbxBox8.BackColor = Color.Blue;
                    break;
                }
                else
                {
                    MessageBox.Show("Cannot add anymore pieces to box!", "We Pack 'Em");
                    break;
                }
            }
        }
    }
}
