using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            // Flarp
            this.productTableAdapter.FillByPrice(this.productDBDataSet.Product);
        }

        private void btnSortByMoreThan100_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnits(this.productDBDataSet.Product);
        }

        private void btnAveragePriceOfAllItems_Click(object sender, EventArgs e)
        {
            decimal averagePrice;

            // Average of all items
            averagePrice = (decimal)productTableAdapter.AveragePrice();

            // Display average of all items
            MessageBox.Show("averagePrice price of all items: " +
                averagePrice.ToString("c"), "Product Queries", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
