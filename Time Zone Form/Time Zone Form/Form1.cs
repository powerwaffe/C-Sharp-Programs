using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city;

            //Get the city that was selected
            city = lbxCities.SelectedItem.ToString();

            //Switch based on the city selected
            switch(city)
            {
                case "Honolulu":
                    lbSelectedCity.Text = "Hawaii-Aleutian";
                    break;
                case "San Francisco":
                    lbSelectedCity.Text = "Pacific";
                    break;
                case "Denver":
                    lbSelectedCity.Text = "Mountain";
                    break;
                case "Minneapolis":
                    lbSelectedCity.Text = "Central";
                    break;
                case "New York":
                    lbSelectedCity.Text = "Eastern";
                    break;
                default:
                    MessageBox.Show("City Not Found");
                    break;
            }
        }
    }
}
