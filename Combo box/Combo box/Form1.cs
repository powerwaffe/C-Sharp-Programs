﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisplay.Text = cbDropDown.Text;
        }

        private void cbDropDownSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisplay.Text = cbDropDownSimple.Text;
        }

        private void cbDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisplay.Text = cbDropDownList.Text;
        }
    }
}
