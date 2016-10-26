using System.Drawing;
using System.Windows.Forms;

namespace Drawing_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create a graphics object
            Graphics g = CreateGraphics();

            // The pen will be red and 2 pixels wide
            Pen p = new Pen(Color.Red, 2);

            // The rectangle starts at 20, 20
            // and is 50 pixels wide, 75 pixels high
            g.DrawRectangle(p, 20, 20, 50, 75);

            // Draw a circle starting at 100, 100
            // and 50 pixels wide, 50 pixels high
            g.DrawEllipse(p, 100, 100, 50, 50);

            // Draw a right triangle with vertices at
            // (200, 200), (200, 250), and (300, 250)
            g.DrawLine(p, 200, 200, 200, 250);
            g.DrawLine(p, 200, 250, 300, 250);
            g.DrawLine(p, 300, 250, 200, 200);
        }
    }
}
