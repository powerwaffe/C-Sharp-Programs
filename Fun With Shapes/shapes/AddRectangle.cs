using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRectangle : Form
    {
        // Create object
        Rectangle rectangle = new Rectangle();

        // Create list object
        List<Rectangle> rectangleShape = new List<Rectangle>();
        
        public AddRectangle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double length = double.Parse(tbxLength.Text);
                double width = double.Parse(tbxWidth.Text);

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Calculate area
                rectangle.Area = length * width;
                lblArea.Text = rectangle.Area.ToString();

                // Calculate perimeter
                rectangle.Perimeter = (length + width) * 2;
                lblPerimeter.Text = rectangle.Perimeter.ToString("#.##");

                rectangleShape.Add(new Rectangle()
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
            foreach (Rectangle aShape in rectangleShape)
            {
                string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
                return date + " - " + aShape.ToString();
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
