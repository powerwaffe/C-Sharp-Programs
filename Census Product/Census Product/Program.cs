using System;
using System.Windows.Forms;

namespace Census_Product
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception e)
            {
                // Display error
                MessageBox.Show(e.Message, "Census Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
