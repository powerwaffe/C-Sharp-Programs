using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            // Display the "light on" image.
            pbxLightOn.Visible = true;

            // Hide the "light off" image.
            pbxLightOff.Visible = false;

            // Display the light's state.
            lblLightState.Text = "ON";
        } // end TurnLightOn

        private void TurnLightOff()
        {
            // Display the "light off" image.
            pbxLightOff.Visible = true;

            // Hide the "light on" image.
            pbxLightOn.Visible = false;

            // Display the lights state.
            lblLightState.Text = "OFF";
        } // end TurnLightOff

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // Reverse the state of the light.
            if (pbxLightOn.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
