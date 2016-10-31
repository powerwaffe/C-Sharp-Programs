using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddSquare : Form
    {
        // Create object
        Rectangle rectangle = new Rectangle();

        // Create list object
        List<Rectangle> squareShape = new List<Rectangle>();

        public AddSquare()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double side1 = double.Parse(tbxSide1.Text);

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Calculate area
                rectangle.Area = Math.Pow(side1, 2);
                lblArea.Text = rectangle.Area.ToString();

                // Calculate perimeter
                rectangle.Perimeter = (side1 * 4);
                lblPerimeter.Text = rectangle.Perimeter.ToString("#.##");

                squareShape.Add(new Rectangle()
                {
                    Area = rectangle.Area,
                    Perimeter = rectangle.Perimeter
                });

                // Increment
                rectangle.Count += 1;
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
            foreach (Rectangle aShape in squareShape)
            {
                return DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy") + " - " +
                     aShape.ToString();
            }
            return null;
        }

        // Return count
        public string getCount()
        {
            return rectangle.Count.ToString();
        }
    }
}
