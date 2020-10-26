using System;
using System.Windows.Forms;



// $G$ THE-001 (-20) your grade on diagrams document - 80 please see comments inside the document. (50% of your grade).

namespace FacebookApplicationUI
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();

            mainForm.ShowDialog();
        }
    }
}