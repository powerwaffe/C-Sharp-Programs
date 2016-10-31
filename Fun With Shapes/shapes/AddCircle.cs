using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddCircle : Form
    {
        // Create object
        Circle circle = new Circle();
        
        // Create list object
        List<Circle> circleShape = new List<Circle>();

        public AddCircle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // PI
                const double PI = 3.14;

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Variables to hold sides
                double radius = double.Parse(tbxRadius.Text);

                // Calculate area
                circle.Area = PI * Math.Pow(radius, 2);
                lblArea.Text = circle.Area.ToString();

                // Calculate perimeter
                circle.Circumference = 2 * (PI * radius);
                lblPerimeter.Text = circle.Circumference.ToString("#.##");

                circleShape.Add(new Circle()
                {
                    Area = circle.Area,
                    Circumference = circle.Circumference
                });

                // Increment
                circle.Count += 1;
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
            foreach (Circle aShape in circleShape)
            {
                return DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy") + " - " +
                     aShape.ToString();
            }
            return null;
        }

        // Return count
        public string getCount()
        {
            return circle.Count.ToString();
        }
    }
}
