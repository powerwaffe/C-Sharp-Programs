using System;
using System.Windows.Forms;

namespace CIS209_DataBaseDemo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrarDataBaseDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.JoinFill(this.registrarDataBaseDataSet.DataTable1);
        }
    }
}
