using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data;

namespace BloodBank
{
    public partial class frmViewRecords : Form
    {
        OleDbConnection dbConnection;
        OleDbCommand oleDBcommand = new OleDbCommand();
        String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=X:\User\Roger\Documents\Visual Studio 2015\Projects\CSharp\BloodBank\KitraDB.accdb";
        //OleDbDataAdapter dbAdapter;
        DataTable dTable = new DataTable();
        String picPath;

        public frmViewRecords()
        {
            dbConnection = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void frmViewRecords_Load(object sender, EventArgs e)
        {
            lblDBOnline.Text = "Connected to Kitra Clients DB";
        }

        private void clientsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }      

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitraDBDataSet);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtType.Text = "";
            txtRH.Text = "";
            chkDonor.Checked = false;
            chkRecipient.Checked = false;
            chkScreened.Checked = false;
            lblRecordStatus.Text = "";
            picPath = String.Empty;
            picClient.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int donor, recipient, screened;
            if (chkDonor.Checked == true)
                donor = 1;
            else
                donor = 0;
            if (chkRecipient.Checked == true)
                recipient = 1;
            else
                recipient = 0;
            if (chkScreened.Checked == true)
                screened = 1;
            else
                screened = 0;
            
            dbConnection.Open();
            oleDBcommand.Connection = dbConnection;
            oleDBcommand.CommandText = "insert into clients (FNAME,LNAME,PHONE,ADDRESS,STREET,CITY,STATE,ZIP,BLOOD_TYPE,RH_FACTOR,SCREENED,DONOR,RECIPIENT,[IMAGE]) values ('"+ txtFirst.Text.Trim().ToUpper()+"','"+txtLast.Text.Trim().ToUpper() +"', '" + txtPhone.Text.Trim()+ "', '" + Convert.ToInt32(txtAddress.Text)+"', '"+txtStreet.Text.Trim().ToUpper() + "', '"+txtCity.Text.Trim().ToUpper()+"', '"+txtState.Text.Trim().ToUpper() + "', '"+Convert.ToInt32(txtZip.Text)+ "','" + txtType.Text.Trim().ToUpper() + "', '" + txtRH.Text.Trim().ToUpper() + "', " + screened +", " + donor +", "+ recipient + ",'"+ picPath.TrimEnd() +"')";
            int temp = oleDBcommand.ExecuteNonQuery();
            if (temp > 0)
                lblRecordStatus.Text = "Record Added";            
            else
                lblRecordStatus.Text = "Error - Record could not be added";
            dbConnection.Close();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            String fileName;
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            String filter = openPic.Filter;
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                fileName = openPic.FileName;
                picClient.Image = new Bitmap(fileName);
                picPath = fileName;
            }
        }     
    }
}
