// frmAbout

// This form provides the user information on the software
using System;
using System.Windows.Forms;



namespace Kitra
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   // Loads frmHome
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
