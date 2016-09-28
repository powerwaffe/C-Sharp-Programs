using System;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        // Declare global variables
        decimal medical, surgical, lab, rehabilitation, totalMisc, total;
        int days, totalDays;

        public Form1()
        {
            InitializeComponent();
        }

        private int CalcStayCharges(int days)
        {
            return days * 350;
        } // end CalcStayCharges

        private decimal CalcMiscCharges(decimal medical, decimal surgical, decimal lab,
            decimal rehabilitation)
        {
            return medical + surgical + lab + rehabilitation;
        } // end CalcMiscCharges

        private decimal CalcTotalCharges(decimal miscCharges, int stayCharges)
        {
            return miscCharges + stayCharges;
        } // end CalcTotalCharges

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get days spent in hospital
            if (int.TryParse(tbxDaysSpentInHospital.Text, out days))
            {
                // Get medical charges
                if (decimal.TryParse(tbxMedicalCharges.Text, out medical))
                {
                    // Get surgical charges
                    if (decimal.TryParse(tbxSurgicalCharges.Text, out surgical))
                    {
                        // Get lab fees
                        if (decimal.TryParse(tbxLabFees.Text, out lab))
                        {
                            // Get rehabilitation fees
                            if (decimal.TryParse(tbxRehabilitationCharges.Text, out rehabilitation))
                            {
                                // Calculate stay charges
                                totalDays = CalcStayCharges(days);

                                // Calculate misc charges
                                totalMisc = CalcMiscCharges(medical, surgical, lab, rehabilitation);

                                // Calculate total charges
                                total = CalcTotalCharges(totalMisc, totalDays);

                                // Display total and return as currency string
                                tbxTotal.Text = total.ToString("c");
                            }
                            else
                            {
                                MessageBox.Show("Invalid input, please use numerica data.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input, please use numerica data.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input, please use numerica data.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input, please use numerica data.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input, please use numerica data.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            tbxDaysSpentInHospital.Text = "";
            tbxLabFees.Text = "";
            tbxMedicalCharges.Text = "";
            tbxRehabilitationCharges.Text = "";
            tbxSurgicalCharges.Text = "";
            tbxTotal.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close program
            Close();
        }
    }
}
