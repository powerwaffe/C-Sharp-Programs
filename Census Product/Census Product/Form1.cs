﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: This line of code loads data into the 'myTownDBDataSet1.VacantView' table. You can move, or remove it, as needed.
            this.vacantViewTableAdapter.Fill(this.myTownDBDataSet1.VacantView);
            // TODO: This line of code loads data into the 'myTownDBDataSet.HomelessView' table. You can move, or remove it, as needed.
            this.homelessViewTableAdapter.Fill(this.myTownDBDataSet.HomelessView);
            // TODO: This line of code loads data into the 'joinDataSet.PersonAddressView2' table. You can move, or remove it, as needed.
            this.personAddressView2TableAdapter.Fill(this.joinDataSet.PersonAddressView2);

        }
    }
}
