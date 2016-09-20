using System;
using System.Windows.Forms;
// Was not able to finish senior percentage nor was I able to finish subtotal,
// tax, and total.

namespace Exam1_Ticket_Sales
{
    public partial class Form1 : Form
    {
        int ticketAdult, ticketChild, ticketSenior;
        double ticketBasePrice, adultBase, childBase, seniorBase;
        double total = 0;

        private void btnIncrementAdult_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxAdultTicketCount.Text) < 6)
                ticketAdult++;
            tbxAdultTicketCount.Text = ticketAdult.ToString();
            double adultBase = double.Parse(tbxBaseTicketPrice.Text) * ticketAdult;
            total += adultBase / ticketAdult;
            tbxDisplayAdultBase.Text = adultBase.ToString();
            tbxSubtotal.Text = total.ToString();
        }

        private void btnDecrementAdult_Click(object sender, EventArgs e)
        {
           if (int.Parse(tbxAdultTicketCount.Text) > 0)
                ticketAdult--;
            tbxAdultTicketCount.Text = ticketAdult.ToString();
            //decimal adultBase = decimal.Parse(tbxBaseTicketPrice.Text); 
        }

        private void btnDecrementChild_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxChildTicketCount.Text) > 0)
                ticketChild--;
            tbxChildTicketCount.Text = ticketChild.ToString();
        }

        private void btnIncrementChild_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxChildTicketCount.Text) < 6)
                ticketChild++;

            tbxChildTicketCount.Text = ticketChild.ToString();
            double childDiscount = double.Parse(tbxBaseTicketPrice.Text) * 50 / 100;
            double childBase = (double.Parse(tbxBaseTicketPrice.Text) * ticketChild) / 2;
            total += childBase / ticketChild;
            tbxDisplayChildBase.Text = childBase.ToString();
            tbxSubtotal.Text = total.ToString();
        }

        private void btnIncrementSenior_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxSeniorTicketCount.Text) < 6)
                ticketSenior++;

            tbxSeniorTicketCount.Text = ticketSenior.ToString();
            double seniorDiscount = (double.Parse(tbxBaseTicketPrice.Text) * ticketSenior) * .25;
            double seniorBase = (double.Parse(tbxBaseTicketPrice.Text) * ticketSenior) - seniorDiscount;
            total += seniorBase / ticketSenior;
            tbxDisplaySeniorBase.Text = seniorBase.ToString();
            tbxSubtotal.Text = total.ToString();


        }

        private void tbxBaseTicketPrice_TextChanged(object sender, EventArgs e)
        {
          //  ticketBasePrice = double.Parse(tbxBaseTicketPrice.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxAdultTicketCount.Text = "0";
            tbxBaseTicketPrice.Text = "0";
            tbxChildTicketCount.Text = "0";
            tbxDisplayAdultBase.Text = "0";
            tbxDisplayChildBase.Text = "0";
            tbxDisplaySeniorBase.Text = "0";
            tbxSeniorTicketCount.Text = "0";
            tbxSubtotal.Text = "0";
            tbxTaxedSubtotal.Text = "0";
            tbxTotal.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxSubtotal_TextChanged(object sender, EventArgs e)
        {
            // Cannot display subtotal
           // double total = adultBase + seniorBase + childBase;
           // tbxSubtotal.Text = total.ToString();
        }

        private void btnDecrementSenior_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxSeniorTicketCount.Text) > 0)
                ticketSenior--;
            tbxSeniorTicketCount.Text = ticketSenior.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
