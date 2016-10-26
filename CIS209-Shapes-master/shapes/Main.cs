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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void rbtnRightTriange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRightTriangle.Checked)
            {
                AddRightTriangle frmTriangle = new AddRightTriangle();
                frmTriangle.ShowDialog();
                rbtnRightTriangle.Checked = false;
            }
        }
    }
}
