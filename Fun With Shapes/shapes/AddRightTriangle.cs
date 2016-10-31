using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRightTriangle : Form
    {
        // Create object
        Shape rightTriangle = new Shape();

        // List object
        List<Shape> triangleShape = new List<Shape>();

        public AddRightTriangle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double side1 = double.Parse(tbxSide1.Text);
                double side2 = double.Parse(tbxSide2.Text);

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Calculate Hypotenuse
                rightTriangle.Hypotenuse = Math.Sqrt(Math.Pow(side1, side2) +
                    Math.Pow(side1, side2));
                lblHypotenuse.Text = rightTriangle.Hypotenuse.ToString("#.##");

                // Calculate area
                rightTriangle.Area = side1 * side2;
                lblArea.Text = rightTriangle.Area.ToString();

                // Calculate perimeter
                rightTriangle.Perimeter = (side1 + side2) + rightTriangle.Hypotenuse;
                lblPerimeter.Text = rightTriangle.Perimeter.ToString("#.##");

                triangleShape.Add(new Shape()
                {
                    Hypotenuse = rightTriangle.Hypotenuse,
                    Area = rightTriangle.Area,
                    Perimeter = rightTriangle.Perimeter
                });

                // Increment
                rightTriangle.Count += 1;
            }
            catch (Exception)
            {
                // Display error message
                MessageBox.Show("Value must be numeric");
            }
        }

        // Return shape
        public string getItem()
        {
            foreach (Shape aShape in triangleShape)
            {
                return DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy") + " - " +
                     aShape.ToString();
            }
            return null;
        }

        // Return count
        public string getCount()
        {
            return rightTriangle.Count.ToString();
        }
    }
}
