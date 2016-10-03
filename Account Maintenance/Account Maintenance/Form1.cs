using System;
using System.IO;
using System.Windows.Forms;

namespace Account_Maintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxAccountList.Items.Add(tbxAccountToAdd.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string account;
                StreamReader inputFile = File.OpenText("C:\\Users\\Sean\\Source\\Repos\\C-Sharp-Programs\\Account Maintenance\\Account Maintenance\\bin\\Debug\\accounts.txt");

                while (!inputFile.EndOfStream)
                {
                    // Read line and store in account variable
                    account = inputFile.ReadLine();

                    // Display list box elements
                    lbxAccountList.Items.Add(account);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Maintenance",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = new StreamWriter("C:\\Users\\Sean\\Source\\Repos\\C-Sharp-Programs\\Account Maintenance\\Account Maintenance\\bin\\Debug\\accounts.txt");
            
            foreach (var accounts in lbxAccountList.Items)
            {
                outputFile.WriteLine(accounts);
            }
            outputFile.Close();
            Close();
        }
    }
}
