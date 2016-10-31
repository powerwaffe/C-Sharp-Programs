using System;
using System.Windows.Forms;
// Sorting method for area and perimeter not added. Increment doesnt
// increment upon form leave. Multiple add clicks dont add multiple
// entries.

namespace shapes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void rbtnRightTriange_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnRightTriangle.Checked)
                {
                    AddRightTriangle frmTriangle = new AddRightTriangle();
                    frmTriangle.ShowDialog();
                    rbtnRightTriangle.Checked = false;

                    // Dispaly items
                    lbxListOfShapes.Items.Add(frmTriangle.getItem());
                    lblCountRightTriangles.Text = frmTriangle.getCount();
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnSquare.Checked)
                {
                    AddSquare frmSquare = new AddSquare();
                    frmSquare.ShowDialog();
                    rbtnRightTriangle.Checked = false;

                    // Display items
                    lbxListOfShapes.Items.Add(frmSquare.getItem());
                    lblCountSquares.Text = frmSquare.getCount();
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnRectangle.Checked)
                {
                    AddRectangle frmRectangle = new AddRectangle();
                    frmRectangle.ShowDialog();
                    rbtnRightTriangle.Checked = false;

                    // Display items
                    lbxListOfShapes.Items.Add(frmRectangle.getItem());
                    lblCountRectangles.Text = frmRectangle.getCount();
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnCircle.Checked)
                {
                    AddCircle frmCircle = new AddCircle();
                    frmCircle.ShowDialog();
                    rbtnRightTriangle.Checked = false;

                    // Display items
                    lbxListOfShapes.Items.Add(frmCircle.getItem());
                    lblCountCircles.Text = frmCircle.getCount();
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }
    }
}
