using System;
using System.Windows.Forms;
using FacebookApplicationLogic;

namespace FacebookApplicationUI
{
    public partial class PackageForm : Form
    {
        public eUserType UserChoosenType { get; set; }

        public PackageForm()
        {
            InitializeComponent();
        }

        private void FreePackageButton_Click(object sender, EventArgs e)
        {
            UserChoosenType = eUserType.eTrialUser;
            Close();
        }

        private void BusinessUserButton_Click(object sender, EventArgs e)
        {
            UserChoosenType = eUserType.eBusinessUser;
            Close();
        }

        private void PremiumUserButton_Click(object sender, EventArgs e)
        {
            UserChoosenType = eUserType.ePremiumUser;
            Close();
        }
    }
}