using System;
using System.Windows.Forms;

namespace control_array_demo_1
{
    public partial class Form1 : Form
    {
        // Declare an array of Label objects (global)
        Label[] labels;

        public Form1()
        {
            InitializeComponent();

            // Load the labels array with Label objects
            labels = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5 };

            // Put an index number in each label
            for (int i = 1; i <= labels.Length; i++)
                labels[i - 1].Text = i.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Increment the value shown in each label
            for (int i = 0; i < labels.Length; i++)
                labels[i].Text = (int.Parse(labels[i].Text) + 1).ToString();  

            // This also works with foreach loops
            foreach (Label item in labels) {
                item.Text = (int.Parse(item.Text) + 1).ToString();
            }             
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= labels.Length; i++)
                labels[i - 1].Text = i.ToString();
        }
    }
}
