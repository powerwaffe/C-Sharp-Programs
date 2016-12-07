using System;
using System.Collections;
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

                    // Dispaly items in details tab
                    lbxListOfShapes.Items.Add(frmTriangle.getItem());
                    lblCountRightTriangles.Text = frmTriangle.getCount();

                    // Display items in sort tab
                    lbxSortedShapes.Items.Add(frmTriangle.getItem());
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

                    // Dispaly items in details tab
                    lbxListOfShapes.Items.Add(frmSquare.getItem());
                    lblCountSquares.Text = frmSquare.getCount();

                    // Display items in sort tab
                    lbxSortedShapes.Items.Add(frmSquare.getItem());
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

                    // Dispaly items in details tab
                    lbxListOfShapes.Items.Add(frmRectangle.getItem());
                    lblCountRectangles.Text = frmRectangle.getCount();

                    // Display items in sort tab
                    lbxSortedShapes.Items.Add(frmRectangle.getItem());
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

                    // Dispaly items in details tab
                    lbxListOfShapes.Items.Add(frmCircle.getItem());
                    lblCountCircles.Text = frmCircle.getCount();

                    // Display items in sort tab
                    lbxSortedShapes.Items.Add(frmCircle.getItem());
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        // Sort Ascending
        private void rbtnSortByArea_CheckedChanged(object sender, EventArgs e)
        {
            ArrayList Sorting = new ArrayList();

            foreach (var o in lbxSortedShapes.Items)
            {
                Sorting.Add(o);
            }

            Sorting.Sort();

            lbxSortedShapes.Items.Clear();

            foreach (var o in Sorting)
            {
                lbxSortedShapes.Items.Add(o);
            }
        }

        // Sort descending
        private void rbtnSortByPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            ArrayList Sorting = new ArrayList();

            foreach (var o in lbxSortedShapes.Items)
            {
                Sorting.Add(o);
            }

            Sorting.Sort(new ReverseSort());

            lbxSortedShapes.Items.Clear();

            foreach (var o in Sorting)
            {
                lbxSortedShapes.Items.Add(o);
            }
        }
    }
}
