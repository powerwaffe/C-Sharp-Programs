using System;
using System.Windows.Forms;

namespace Census_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myTownDBDataSet3.AddressView' table. You can move, or remove it, as needed.
            this.addressViewTableAdapter.Fill(this.myTownDBDataSet3.AddressView);
            // TODO: This line of code loads data into the 'myTownDBDataSet2.PersonView' table. You can move, or remove it, as needed.
            this.personViewTableAdapter.Fill(this.myTownDBDataSet2.PersonView);
            // TODO: This line of code loads data into the 'myTownDBDataSet1.VacantView' table. You can move, or remove it, as needed.
            this.vacantViewTableAdapter.Fill(this.myTownDBDataSet1.VacantView);
            // TODO: This line of code loads data into the 'myTownDBDataSet.HomelessView' table. You can move, or remove it, as needed.
            this.homelessViewTableAdapter.Fill(this.myTownDBDataSet.HomelessView);
            // TODO: This line of code loads data into the 'joinDataSet.PersonAddressView2' table. You can move, or remove it, as needed.
            this.personAddressView2TableAdapter.Fill(this.joinDataSet.PersonAddressView2);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // Exit program
        }
    }
}
