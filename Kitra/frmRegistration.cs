// Roger Greer
// Programming in C# 
// Course Project
// frmRegistration

// This form allows the user to add clients to the KitraDB database. It validates and formats user input on the front end of the Utility method AddClient().
// Image files are save as absolute path in the database. Relative path will be added in future release.
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Kitra
{
    public partial class frmRegistration : Form
    {
        // Stores the image path variable
        String picPath;

        public frmRegistration()
        {

            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   // Clears all textboxes, checkboxes, and the current image path. Enables btnAdd 
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
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool dataValidated = false;
            // Formats checkbox check state to boolean value for AddClient().
            // These fields are MS Access Yes/No values and must be converted.
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
       
            if (ValidateInput(dataValidated) == true)
            {
                try
                {
                    // Sets variable values in Utility
                    Utility register = new Utility();
                    register.first = txtFirst.Text.Trim().ToUpper();
                    register.last = txtLast.Text.Trim().ToUpper();
                    register.phone = Convert.ToInt64(txtPhone.Text.TrimEnd());
                    register.address = Convert.ToInt64(txtAddress.Text.TrimEnd());
                    register.street = txtStreet.Text.Trim().ToUpper();
                    register.city = txtCity.Text.Trim().ToUpper();
                    register.state = txtState.Text.Trim().ToUpper();
                    register.zip = Convert.ToInt32(txtZip.Text.TrimEnd());
                    register.type = txtType.Text.Trim().ToUpper();
                    register.factor = txtRH.Text.Trim().ToUpper();
                    register.donor = donor;
                    register.recipient = recipient;
                    register.screened = screened;
                    register.photo = picPath;
                    // Calls AddClient() for client record insertion
                    register.AddClient();
                    // Ensure user cannot enter duplicate records, re-enabled by btnClear
                    btnAdd.Enabled = false;
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Please ensure all data fields have been entered", "Input Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {   // This method calls the OpenFileDialog to select a client picture from file.
            String fileName;
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            String filter = openPic.Filter;
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                // Gets then sets the image path for the picturebox
                fileName = openPic.FileName;
                picClient.Image = new Bitmap(fileName);
                // Need to convert to relative path for insert into database
                picPath = fileName;
            }
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

        private bool ValidateInput(bool isValidated)
        {   // This method ensures data validation before record is added to the database
            isValidated = false;
            int errorCount = 0;
            if (string.IsNullOrEmpty(txtFirst.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtLast.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtPhone.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtPhone.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtStreet.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtAddress.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtCity.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtState.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtZip.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtType.Text))
                errorCount++;
            if (string.IsNullOrEmpty(txtRH.Text))
                errorCount++;

            int i;
            if (!int.TryParse(txtPhone.Text, out i))
            {
                MessageBox.Show("Please enter a ten digit phone number", "Input Error", MessageBoxButtons.OK);
                txtPhone.Focus();
                errorCount++;
            }
            int j;
            if (!int.TryParse(txtAddress.Text, out j))
            {
                MessageBox.Show("Please enter a numeric street address", "Input Error", MessageBoxButtons.OK);
                txtPhone.Focus();
                errorCount++;
            }
            int k;
            if (!int.TryParse(txtZip.Text, out k))
            {
                MessageBox.Show("Please enter a five digit zip code", "Input Error", MessageBoxButtons.OK);
                txtZip.Focus();
                errorCount++;
            }

            if (picPath == null)
            {
                MessageBox.Show("Please add a client picture", "Input Error", MessageBoxButtons.OK);
                btnPhoto.Focus();
                errorCount++;
            }
            if (errorCount == 0)
                return isValidated = true;
            else
            {
                MessageBox.Show("Please ensure all data fields have been entered", "Input Error", MessageBoxButtons.OK);
                return isValidated = false;
            }
           
        }
    }
}
