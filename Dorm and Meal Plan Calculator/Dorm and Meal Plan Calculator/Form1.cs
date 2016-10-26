using System;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    // enum values to be used for calculations
    enum Dorm
    {
        allen = 1500, pike = 1600, farthing = 1800,
        universitySuites = 2500, sevenMeals = 600,
        fourteenMeals = 1200, unlimitedMeals = 1700,
    }
    public partial class frmDormAndMealPlans : Form
    {
        // Global variables
        double total;
        double value1 = 0, value2 = 0;

        public frmDormAndMealPlans()
        {
            InitializeComponent();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            // Create an instance of frmTotalCharges
            frmTotalCharges totalCharges = new frmTotalCharges();

            // Check what dormitory is selected
            if (rbtAllenHall.Checked)
            {
                value1 += (double)Dorm.allen;
                total += value1;
            }
            else if (rbtPikeHall.Checked)
            {
                value1 += (double)Dorm.pike;
                total += value1;
            }
            else if (rbtFarthingHall.Checked)
            {
                value1 += (double)Dorm.farthing;
                total += value1;
            }
            else if (rbtUniversitySuite.Checked)
            {
                value1 += (double)Dorm.universitySuites;
                total += value1;
            }

            // Check what meal plan is selected
            if (rbt7MealsPerWeek.Checked)
            {
                value2 += (double)Dorm.sevenMeals;
                total = value1 + value2;
            }
            else if (rbt14MealsPerWeek.Checked)
            {
                value2 += (double)Dorm.fourteenMeals;
                total = value1 + value2;
            }
            else if (rbtUnlimitedMeals.Checked)
            {
                value2 += (double)Dorm.unlimitedMeals;
                total = value1 + value2;
            }

            // Set label in frmTotalCharges to total's value
            totalCharges.lblTotalCharges.Text = total.ToString();

            // Display frmTotalCharges
            totalCharges.ShowDialog();

            // Set all values to 0 after form finishes executing
            total = 0;
            value1 = 0;
            value2 = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
