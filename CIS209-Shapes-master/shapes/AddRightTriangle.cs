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
    public partial class AddRightTriangle : Form
    {
        public AddRightTriangle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create object
            Shape rightTriangle = new Shape();

            List<Shape> triangleShape = new List<Shape>();

            // Variables to hold sides
            double side1 = double.Parse(tbxSide1.Text);
            double side2 = double.Parse(tbxSide2.Text);

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
                Hypotenuse =rightTriangle.Hypotenuse, Area = rightTriangle.Area,
                Perimeter = rightTriangle.Perimeter
            });

            foreach (Shape aShape in triangleShape)
            {
                MessageBox.Show(aShape.ToString());
            }
        }
    }
}
