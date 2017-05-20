// Roger Greer
// Programming in C# 
// Course Project
// frmHelp

// This form will provide quick start help in the next release.
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
