// frmViewRecords

// This form allows the user to view and navigate between client records currently in the MS Access KitraDB database using ADO.Net. The user must remap the datasource to the 
// MS Access database on their local machine.
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace Kitra
{
    public partial class frmViewRecords : Form
    { 
        public frmViewRecords()
        {
            InitializeComponent();
        }

        private void frmViewRecords_Load(object sender, EventArgs e)
        {   // On form load the first record from the database is displayed
            Utility dbUtils = new Utility();
            OleDbConnection dbConnection = new OleDbConnection(dbUtils.connParam);
            try
            {
                dbConnection.Open();
                lblDBOnline.Text = "Connected to Kitra Clients DB";
                OleDbDataAdapter dtAdapter = new OleDbDataAdapter(dbUtils.queryAll, dbConnection);

                // Load data into the 'kitraDBDataSet.Clients' table. 
                clientsTableAdapter.Fill(this.kitraDBDataSet.Clients);
                DataMap();
            }

            catch
            {
                MessageBox.Show("Database is unavailable", "Database Error", MessageBoxButtons.OK);
            }   

            finally
            {
                dbConnection.Close();
            }  
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {   // Binds the form label output to the client table from the database
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitraDBDataSet);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {   // Advances to the next record
            if (clientsBindingSource.Position + 1 < clientsBindingSource.Count)
            {
                clientsBindingSource.MoveNext();
                DataMap();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {   // Advances to the previous record
            if (clientsBindingSource.Position - 1 < clientsBindingSource.Count)
            {
                clientsBindingSource.MovePrevious();
                DataMap();
            }
        }

        public void DataMap()
        {   // This method loads the clients image path to the picture box and sets the checked property for the 
            // donor, screened, recipient check boxes based on boolean values from the database.
            
            string imageLocation = lblImageLocation.Text;
            picDBclient.Image = new Bitmap(imageLocation);
            // These fields are MS Access Yes/No values and must be converted
            if (lblDBdonor.Text == Convert.ToString(true))
                chkDonor.Checked = true;
            else chkDonor.Checked = false;
            if (lblDBrecipient.Text == Convert.ToString(true))
                chkRecipient.Checked = true;
            else chkRecipient.Checked = false;
            if (lblDBscreened.Text == Convert.ToString(true))
                chkScreened.Checked = true;
            else chkScreened.Checked = false;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {   // Loads frmRecords
            frmRecords frmRecords = new frmRecords();
            frmRecords.Show();
            this.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   // Loads frmHome
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }
    }
}

    