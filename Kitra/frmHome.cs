// Roger Greer
// Programming in C# 
// Course Project
// frmHome

// This form is the home screen for Blood Bank management functions
using System;
using System.Windows.Forms;

namespace Kitra
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void tsmReports_Click(object sender, EventArgs e)
        {   // Loads frmRecords
            frmRecords frmRecords = new frmRecords();
            frmRecords.Show();
            this.Visible = false;
        }

        private void tsmSearch_Click(object sender, EventArgs e)
        {   // Loads frmSearch
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
            this.Visible = false;
        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {   // loads frmHelp;
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
            this.Visible = false;
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {   // Loads frmAbout
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
            this.Visible = false;
        }
        
        private void btnReports_Click(object sender, EventArgs e)
        {   // Loads frmReports
            frmRecords frmRecords = new frmRecords();
            frmRecords.Show();
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   // Loads frmSearch
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   // Loads the close program dialog
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {   // Loads the close program dialog
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
