using System;
using System.Windows.Forms;

namespace Chapter11_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookPublisherDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookPublisherDataSet1.Books);
            // TODO: This line of code loads data into the 'bookPublisherDataSet1.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.bookPublisherDataSet1.Authors);

        }

        // Saves for first tab
        private void toolStripButtonSave1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookPublisherDataSet1);
        }

        // Saves for second tab
        private void toolStripButtonSave2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookPublisherDataSet1);
        }

        // Saves for third tab
        private void toolStripButtonSave3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookPublisherDataSet1);
        }

        // Saves for fourth tab
        private void toolStripButtonSave4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookPublisherDataSet1);
        }

        // Catch exception for authors data grid
        private void authorsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error trying to " + e.Context.ToString());
        }

        // Catch exception for books data grid
        private void booksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error trying to " + e.Context.ToString());
        }
    }
}
