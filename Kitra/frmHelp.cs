// frmHelp

// This form will provide quick start help given any features the user wants to add.
using System;
using System.Windows.Forms;

namespace Kitra
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   // Loads frmHome
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }
    }
}
