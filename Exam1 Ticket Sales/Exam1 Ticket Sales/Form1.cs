using System;
using System.Windows.Forms;
// The decrement buttons only do proper calculations when not mixed
// with the other counters. If you have 2 of each ticket and decrement one,
// the math will be wrong. Although it works when you have 2 of one ticket type
// and decrement only that ticket type alone.

namespace Exam1_Ticket_Sales
{
    public partial class Form1 : Form
    {
        // Global variables to be used
        int ticketAdult, ticketChild, ticketSenior;
        decimal subTotal = 0;
        double taxSubtobtotal, adultBase, childBase, seniorBase;
        decimal total;

        private void btnIncrementAdult_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbxAdultTicketCount.Text) < 6)
                {
                    if (decimal.Parse(tbxBaseTicketPrice.Text) < 5 || decimal.Parse(tbxBaseTicketPrice.Text) > 20)
                    {
                        MessageBox.Show("Ticket base price must be between 5 and 20");
                    }
                    else
                    {
                        // Increment and do calculations
                        ticketAdult++;
                        tbxAdultTicketCount.Text = ticketAdult.ToString();
                        adultBase = double.Parse(tbxBaseTicketPrice.Text) * ticketAdult;
                        subTotal += (decimal)adultBase / ticketAdult;
                        tbxDisplayAdultBase.Text = adultBase.ToString("##.##");
                        tbxSubtotal.Text = subTotal.ToString("#.##");

                        // Calculate and show taxedSubtotal
                        taxSubtobtotal = (double)subTotal * .06;
                        tbxTaxedSubtotal.Text = taxSubtobtotal.ToString("#.##");

                        // Display total subtracting taxSubtotal
                        total = (decimal)subTotal - (decimal)taxSubtobtotal;
                        tbxTotal.Text = total.ToString("#.##");
                    }
                }
                else
                {
                    // Warning if tickets exceed set limit
                    MessageBox.Show("The limit is 6 tickets.");
                }
            }
            catch
            {
                // Non decimal response
                MessageBox.Show("Must be a decimal value.");
            }
        }

        private void btnDecrementAdult_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxAdultTicketCount.Text) > 0)
            {
                // Decrement tickets and sales calculations
                subTotal -= subTotal / ticketAdult;
                total -= total / ticketAdult;
                taxSubtobtotal -= taxSubtobtotal / ticketAdult;
                adultBase -= adultBase / ticketAdult;
                ticketAdult--;

                // Display Changes
                tbxAdultTicketCount.Text = ticketAdult.ToString();
                tbxDisplayAdultBase.Text = adultBase.ToString();
                tbxSubtotal.Text = subTotal.ToString();
                tbxTotal.Text = total.ToString();
                tbxTaxedSubtotal.Text = taxSubtobtotal.ToString();
            }
        }

        private void btnDecrementChild_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxChildTicketCount.Text) > 0)
            {
                // Decrement tickets and sales calculations
                subTotal -= subTotal / ticketChild;
                total -= total / ticketChild;
                taxSubtobtotal -= taxSubtobtotal / ticketChild;
                childBase -= childBase / ticketChild;
                ticketChild--;

                // Display Changes
                tbxChildTicketCount.Text = ticketChild.ToString();
                tbxDisplayChildBase.Text = childBase.ToString();
                tbxSubtotal.Text = subTotal.ToString();
                tbxTotal.Text = total.ToString();
                tbxTaxedSubtotal.Text = taxSubtobtotal.ToString();
            }
        }

        private void btnIncrementChild_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbxChildTicketCount.Text) < 6)
                {
                    if (decimal.Parse(tbxBaseTicketPrice.Text) < 5 || decimal.Parse(tbxBaseTicketPrice.Text) > 20)
                        MessageBox.Show("Ticket base price must be between 5 and 20");   
                    else
                    {
                        // Increment and do calculations
                        ticketChild++;
                        tbxChildTicketCount.Text = ticketChild.ToString();
                        childBase = (double.Parse(tbxBaseTicketPrice.Text) * ticketChild) / 2;
                        subTotal += (decimal)childBase / ticketChild;
                        tbxDisplayChildBase.Text = childBase.ToString("#.##");
                        tbxSubtotal.Text = subTotal.ToString("#.##");

                        // Calculate and show taxedSubtotal
                        taxSubtobtotal = (double)subTotal * .06;
                        tbxTaxedSubtotal.Text = taxSubtobtotal.ToString("#.##");

                        // Display total subtracting taxSubtotal
                        total = (decimal)subTotal - (decimal)taxSubtobtotal;
                        tbxTotal.Text = total.ToString("#.##");
                    }
                }
                else
                {
                    // Warning if tickets exceed set limit
                    MessageBox.Show("The limit is 6 tickets.");
                }
            }
            catch
            {
                // Non decimal response
                MessageBox.Show("Must be a decimal value.");
            }
        }

        private void btnIncrementSenior_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbxSeniorTicketCount.Text) < 6)
                {
                    if (decimal.Parse(tbxBaseTicketPrice.Text) < 5 || decimal.Parse(tbxBaseTicketPrice.Text) > 20)
                        MessageBox.Show("Ticket base price must be between 5 and 20");
                    else
                    {
                        // Increment and do calculations
                        ticketSenior++;
                        double seniorDiscount = (double.Parse(tbxBaseTicketPrice.Text) * ticketSenior) * .25;
                        seniorBase = (double.Parse(tbxBaseTicketPrice.Text) * ticketSenior) - seniorDiscount;
                        subTotal += (decimal)seniorBase / ticketSenior;
                        tbxDisplaySeniorBase.Text = seniorBase.ToString("#.##");
                        tbxSubtotal.Text = subTotal.ToString("#.##");
                        tbxSeniorTicketCount.Text = ticketSenior.ToString();

                        // Calculate and show taxedSubtotal
                        taxSubtobtotal = (double)subTotal * .06;
                        tbxTaxedSubtotal.Text = taxSubtobtotal.ToString("#.##");

                        // Display total subtracting taxSubtotal
                        total = (decimal)subTotal - (decimal)taxSubtobtotal;
                        tbxTotal.Text = total.ToString("#.##");
                    }
                }
                else
                {
                    // Warning if tickets exceed set limit
                    MessageBox.Show("The limit is 6 tickets.");
                }
            }
            catch
            {
                // Non decimal response
                MessageBox.Show("Must be a decimal value.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Set all text box's to 0
            tbxAdultTicketCount.Text = "0";
            tbxBaseTicketPrice.Text = ""; // Prefer to leave blank rather than 0
            tbxChildTicketCount.Text = "0";
            tbxDisplayAdultBase.Text = "0";
            tbxDisplayChildBase.Text = "0";
            tbxDisplaySeniorBase.Text = "0";
            tbxSeniorTicketCount.Text = "0";
            tbxSubtotal.Text = "0";
            tbxTaxedSubtotal.Text = "0";
            tbxTotal.Text = "0";

            // Set all variables to 0
            total = 0;
            subTotal = 0;
            taxSubtobtotal = 0;
            ticketAdult = 0;
            ticketChild = 0;
            ticketSenior = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDecrementSenior_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxSeniorTicketCount.Text) > 0)
            {
                // Decrement tickets and sales calculations
                subTotal -= subTotal / ticketSenior;
                total -= total / ticketSenior;
                taxSubtobtotal -= taxSubtobtotal / ticketSenior;
                seniorBase -= seniorBase / ticketSenior;
                ticketSenior--;
               
                // Display Changes
                tbxSeniorTicketCount.Text = ticketSenior.ToString();
                tbxDisplaySeniorBase.Text = seniorBase.ToString();
                tbxSubtotal.Text = subTotal.ToString();
                tbxTotal.Text = total.ToString();
                tbxTaxedSubtotal.Text = taxSubtobtotal.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
