// Roger Greer
// Programming in C# 
// Course Project
// frmRecords

// This form is an intermediate form for records management options. It allows the user to select the registration form, view records form, or home form.
using System;
using System.Windows.Forms;

namespace Kitra
{
    public partial class frmRecords : Form
    {
        public frmRecords()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   // Loads frmRegistration
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
            this.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   // Loads frmHome 
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {   // Loads frmViewRecords
            frmViewRecords frmViewRecords = new frmViewRecords();
            frmViewRecords.Show();
            this.Visible = false;
        }
    }
}
