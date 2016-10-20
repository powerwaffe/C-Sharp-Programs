using System;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    enum Dorm
    {
        allen = 1500, pike = 1600, farthing = 1800,
        universitySuites = 2500, sevenMeals = 600,
        fourteenMeals = 1200, unlimitedMeals = 1700,
    }
    public partial class frmDormAndMealPlans : Form
    {
        public frmDormAndMealPlans()
        {
            InitializeComponent();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            // Create an instance of frmTotalCharges
            frmTotalCharges totalCharges = new frmTotalCharges();
           
            int counter = 0;
            double value1, value2;
            double total = 0;
            while (counter < 2)
            {
                if (rbtAllenHall.Checked)
                {
                    value1 = (double)Dorm.allen;
                    total += value1;
                    counter++;
                }
                else if (rbtPikeHall.Checked)
                {
                    value1 = (double)Dorm.pike;
                    counter++;
                }
                else if (rbtFarthingHall.Checked)
                {
                    value1 = (double)Dorm.farthing;
                    counter++;
                }
                else if (rbtUniversitySuite.Checked)
                {
                    value1 = (double)Dorm.universitySuites;
                    counter++;
                }
                else if (rbt7MealsPerWeek.Checked)
                {
                    value2 = (double)Dorm.sevenMeals;
                    counter++;
                }
                else if (rbt14MealsPerWeek.Checked)
                {
                    value2 = (double)Dorm.fourteenMeals;
                    counter++;
                }
                else if (rbtUnlimitedMeals.Checked)
                {
                    value2 = (double)Dorm.unlimitedMeals;
                    counter++;
                }
            }
            totalCharges.ShowDialog();
        }

        private void Dormitories_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton rb1 = (RadioButton)sender;
            }

        }
    }
}
