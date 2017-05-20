namespace Kitra
{
    partial class frmViewRecords 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label lblStreet;
            System.Windows.Forms.Label lblCity;
            System.Windows.Forms.Label lblState;
            System.Windows.Forms.Label lblZip;
            System.Windows.Forms.Label lblDonor;
            System.Windows.Forms.Label lblRecipient;
            System.Windows.Forms.Label lblType;
            System.Windows.Forms.Label lblRH;
            System.Windows.Forms.Label lblScreened;
            System.Windows.Forms.Label lblPhone;
            System.Windows.Forms.Label lblIDnum;
            System.Windows.Forms.Label lblLastName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewRecords));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblDBcity = new System.Windows.Forms.Label();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitraDBDataSet = new Kitra.KitraDBDataSet();
            this.lblDBstreet = new System.Windows.Forms.Label();
            this.lblDBzip = new System.Windows.Forms.Label();
            this.lblDBstate = new System.Windows.Forms.Label();
            this.lblDBphone = new System.Windows.Forms.Label();
            this.lblDBaddress = new System.Windows.Forms.Label();
            this.lblDBlast = new System.Windows.Forms.Label();
            this.lblDBfirst = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkScreened = new System.Windows.Forms.CheckBox();
            this.chkRecipient = new System.Windows.Forms.CheckBox();
            this.chkDonor = new System.Windows.Forms.CheckBox();
            this.lblBDfactor = new System.Windows.Forms.Label();
            this.lblBDtype = new System.Windows.Forms.Label();
            this.lblDBOnline = new System.Windows.Forms.Label();
            this.lblRecordStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.lblImageLocation = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new Kitra.KitraDBDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Kitra.KitraDBDataSetTableAdapters.TableAdapterManager();
            this.picDBclient = new System.Windows.Forms.PictureBox();
            this.lblDBdonor = new System.Windows.Forms.Label();
            this.lblDBrecipient = new System.Windows.Forms.Label();
            this.lblDBscreened = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblStreet = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblZip = new System.Windows.Forms.Label();
            lblDonor = new System.Windows.Forms.Label();
            lblRecipient = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            lblRH = new System.Windows.Forms.Label();
            lblScreened = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblIDnum = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitraDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBclient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFirstName.Location = new System.Drawing.Point(6, 26);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(50, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddress.Location = new System.Drawing.Point(6, 86);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(80, 20);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStreet.Location = new System.Drawing.Point(6, 119);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new System.Drawing.Size(64, 20);
            lblStreet.TabIndex = 11;
            lblStreet.Text = "Street:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCity.Location = new System.Drawing.Point(6, 154);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(44, 20);
            lblCity.TabIndex = 13;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblState.Location = new System.Drawing.Point(6, 187);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(58, 20);
            lblState.TabIndex = 15;
            lblState.Text = "State:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblZip.Location = new System.Drawing.Point(6, 217);
            lblZip.Name = "lblZip";
            lblZip.Size = new System.Drawing.Size(39, 20);
            lblZip.TabIndex = 17;
            lblZip.Text = "Zip:";
            // 
            // lblDonor
            // 
            lblDonor.AutoSize = true;
            lblDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDonor.Location = new System.Drawing.Point(22, 92);
            lblDonor.Name = "lblDonor";
            lblDonor.Size = new System.Drawing.Size(63, 20);
            lblDonor.TabIndex = 0;
            lblDonor.Text = "Donor:";
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRecipient.Location = new System.Drawing.Point(23, 119);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new System.Drawing.Size(90, 20);
            lblRecipient.TabIndex = 2;
            lblRecipient.Text = "Recipient:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblType.Location = new System.Drawing.Point(22, 26);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(52, 20);
            lblType.TabIndex = 4;
            lblType.Text = "Type:";
            // 
            // lblRH
            // 
            lblRH.AutoSize = true;
            lblRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRH.Location = new System.Drawing.Point(22, 61);
            lblRH.Name = "lblRH";
            lblRH.Size = new System.Drawing.Size(97, 20);
            lblRH.TabIndex = 6;
            lblRH.Text = "RH Factor:";
            // 
            // lblScreened
            // 
            lblScreened.AutoSize = true;
            lblScreened.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblScreened.Location = new System.Drawing.Point(23, 147);
            lblScreened.Name = "lblScreened";
            lblScreened.Size = new System.Drawing.Size(91, 20);
            lblScreened.TabIndex = 8;
            lblScreened.Text = "Screened:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPhone.Location = new System.Drawing.Point(5, 56);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(65, 20);
            lblPhone.TabIndex = 18;
            lblPhone.Text = "Phone:";
            // 
            // lblIDnum
            // 
            lblIDnum.AutoSize = true;
            lblIDnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIDnum.Location = new System.Drawing.Point(349, 63);
            lblIDnum.Name = "lblIDnum";
            lblIDnum.Size = new System.Drawing.Size(84, 20);
            lblIDnum.TabIndex = 19;
            lblIDnum.Text = "Client ID:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLastName.Location = new System.Drawing.Point(228, 26);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(49, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Records";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(751, 408);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 32);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.lblDBcity);
            this.grpData.Controls.Add(this.lblDBstreet);
            this.grpData.Controls.Add(this.lblDBzip);
            this.grpData.Controls.Add(this.lblDBstate);
            this.grpData.Controls.Add(this.lblDBphone);
            this.grpData.Controls.Add(this.lblDBaddress);
            this.grpData.Controls.Add(this.lblDBlast);
            this.grpData.Controls.Add(this.lblDBfirst);
            this.grpData.Controls.Add(lblPhone);
            this.grpData.Controls.Add(lblFirstName);
            this.grpData.Controls.Add(lblZip);
            this.grpData.Controls.Add(lblState);
            this.grpData.Controls.Add(lblLastName);
            this.grpData.Controls.Add(lblCity);
            this.grpData.Controls.Add(lblAddress);
            this.grpData.Controls.Add(lblStreet);
            this.grpData.Location = new System.Drawing.Point(211, 96);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(447, 272);
            this.grpData.TabIndex = 19;
            this.grpData.TabStop = false;
            this.grpData.Text = "Client Data";
            // 
            // lblDBcity
            // 
            this.lblDBcity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "CITY", true));
            this.lblDBcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBcity.Location = new System.Drawing.Point(95, 154);
            this.lblDBcity.Name = "lblDBcity";
            this.lblDBcity.Size = new System.Drawing.Size(152, 23);
            this.lblDBcity.TabIndex = 27;
            this.lblDBcity.Text = "XXXXXXXXX";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.kitraDBDataSet;
            // 
            // kitraDBDataSet
            // 
            this.kitraDBDataSet.DataSetName = "KitraDBDataSet";
            this.kitraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDBstreet
            // 
            this.lblDBstreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "STREET", true));
            this.lblDBstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBstreet.Location = new System.Drawing.Point(95, 119);
            this.lblDBstreet.Name = "lblDBstreet";
            this.lblDBstreet.Size = new System.Drawing.Size(170, 23);
            this.lblDBstreet.TabIndex = 26;
            this.lblDBstreet.Text = "XXXXXXXXX";
            // 
            // lblDBzip
            // 
            this.lblDBzip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ZIP", true));
            this.lblDBzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBzip.Location = new System.Drawing.Point(95, 217);
            this.lblDBzip.Name = "lblDBzip";
            this.lblDBzip.Size = new System.Drawing.Size(100, 23);
            this.lblDBzip.TabIndex = 25;
            this.lblDBzip.Text = "XXXXXXXXX";
            // 
            // lblDBstate
            // 
            this.lblDBstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "STATE", true));
            this.lblDBstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBstate.Location = new System.Drawing.Point(95, 187);
            this.lblDBstate.Name = "lblDBstate";
            this.lblDBstate.Size = new System.Drawing.Size(100, 23);
            this.lblDBstate.TabIndex = 24;
            this.lblDBstate.Text = "XXXXXXXXX";
            // 
            // lblDBphone
            // 
            this.lblDBphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "PHONE", true));
            this.lblDBphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBphone.Location = new System.Drawing.Point(95, 56);
            this.lblDBphone.Name = "lblDBphone";
            this.lblDBphone.Size = new System.Drawing.Size(127, 23);
            this.lblDBphone.TabIndex = 22;
            this.lblDBphone.Text = "XXXXXXXXX";
            // 
            // lblDBaddress
            // 
            this.lblDBaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ADDRESS", true));
            this.lblDBaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBaddress.Location = new System.Drawing.Point(95, 86);
            this.lblDBaddress.Name = "lblDBaddress";
            this.lblDBaddress.Size = new System.Drawing.Size(152, 23);
            this.lblDBaddress.TabIndex = 21;
            this.lblDBaddress.Text = "XXXXXXXXX";
            // 
            // lblDBlast
            // 
            this.lblDBlast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "LNAME", true));
            this.lblDBlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBlast.Location = new System.Drawing.Point(283, 26);
            this.lblDBlast.Name = "lblDBlast";
            this.lblDBlast.Size = new System.Drawing.Size(151, 23);
            this.lblDBlast.TabIndex = 20;
            this.lblDBlast.Text = "XXXXXXXXX";
            // 
            // lblDBfirst
            // 
            this.lblDBfirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FNAME", true));
            this.lblDBfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBfirst.Location = new System.Drawing.Point(95, 27);
            this.lblDBfirst.Name = "lblDBfirst";
            this.lblDBfirst.Size = new System.Drawing.Size(127, 23);
            this.lblDBfirst.TabIndex = 19;
            this.lblDBfirst.Text = "XXXXXXXXX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkScreened);
            this.groupBox1.Controls.Add(this.chkRecipient);
            this.groupBox1.Controls.Add(this.chkDonor);
            this.groupBox1.Controls.Add(this.lblBDfactor);
            this.groupBox1.Controls.Add(this.lblBDtype);
            this.groupBox1.Controls.Add(lblScreened);
            this.groupBox1.Controls.Add(lblRH);
            this.groupBox1.Controls.Add(lblType);
            this.groupBox1.Controls.Add(lblRecipient);
            this.groupBox1.Controls.Add(lblDonor);
            this.groupBox1.Location = new System.Drawing.Point(664, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 272);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Data";
            // 
            // chkScreened
            // 
            this.chkScreened.AutoSize = true;
            this.chkScreened.Enabled = false;
            this.chkScreened.Location = new System.Drawing.Point(129, 147);
            this.chkScreened.Name = "chkScreened";
            this.chkScreened.Size = new System.Drawing.Size(15, 14);
            this.chkScreened.TabIndex = 13;
            this.chkScreened.UseVisualStyleBackColor = true;
            // 
            // chkRecipient
            // 
            this.chkRecipient.AutoSize = true;
            this.chkRecipient.Enabled = false;
            this.chkRecipient.Location = new System.Drawing.Point(129, 119);
            this.chkRecipient.Name = "chkRecipient";
            this.chkRecipient.Size = new System.Drawing.Size(15, 14);
            this.chkRecipient.TabIndex = 12;
            this.chkRecipient.UseVisualStyleBackColor = true;
            // 
            // chkDonor
            // 
            this.chkDonor.AutoSize = true;
            this.chkDonor.Enabled = false;
            this.chkDonor.Location = new System.Drawing.Point(129, 94);
            this.chkDonor.Name = "chkDonor";
            this.chkDonor.Size = new System.Drawing.Size(15, 14);
            this.chkDonor.TabIndex = 11;
            this.chkDonor.UseVisualStyleBackColor = true;
            // 
            // lblBDfactor
            // 
            this.lblBDfactor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "RH_FACTOR", true));
            this.lblBDfactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDfactor.Location = new System.Drawing.Point(125, 62);
            this.lblBDfactor.Name = "lblBDfactor";
            this.lblBDfactor.Size = new System.Drawing.Size(100, 23);
            this.lblBDfactor.TabIndex = 10;
            this.lblBDfactor.Text = "XXXXXXXXX";
            // 
            // lblBDtype
            // 
            this.lblBDtype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "BLOOD_TYPE", true));
            this.lblBDtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDtype.Location = new System.Drawing.Point(125, 27);
            this.lblBDtype.Name = "lblBDtype";
            this.lblBDtype.Size = new System.Drawing.Size(100, 23);
            this.lblBDtype.TabIndex = 9;
            this.lblBDtype.Text = "XXXXXXXXX";
            // 
            // lblDBOnline
            // 
            this.lblDBOnline.AutoSize = true;
            this.lblDBOnline.Location = new System.Drawing.Point(23, 419);
            this.lblDBOnline.Name = "lblDBOnline";
            this.lblDBOnline.Size = new System.Drawing.Size(0, 13);
            this.lblDBOnline.TabIndex = 22;
            // 
            // lblRecordStatus
            // 
            this.lblRecordStatus.AutoSize = true;
            this.lblRecordStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordStatus.Location = new System.Drawing.Point(379, 408);
            this.lblRecordStatus.Name = "lblRecordStatus";
            this.lblRecordStatus.Size = new System.Drawing.Size(0, 16);
            this.lblRecordStatus.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(439, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 19;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(423, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 32);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(261, 374);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 32);
            this.btnPrevious.TabIndex = 29;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Location = new System.Drawing.Point(620, 408);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(107, 32);
            this.btnRecords.TabIndex = 31;
            this.btnRecords.Text = "&Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // lblImageLocation
            // 
            this.lblImageLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "IMAGE", true));
            this.lblImageLocation.Location = new System.Drawing.Point(38, 212);
            this.lblImageLocation.Name = "lblImageLocation";
            this.lblImageLocation.Size = new System.Drawing.Size(100, 23);
            this.lblImageLocation.TabIndex = 32;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kitra.KitraDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picDBclient
            // 
            this.picDBclient.Location = new System.Drawing.Point(12, 96);
            this.picDBclient.Name = "picDBclient";
            this.picDBclient.Size = new System.Drawing.Size(190, 266);
            this.picDBclient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDBclient.TabIndex = 33;
            this.picDBclient.TabStop = false;
            // 
            // lblDBdonor
            // 
            this.lblDBdonor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "DONOR", true));
            this.lblDBdonor.Location = new System.Drawing.Point(63, 117);
            this.lblDBdonor.Name = "lblDBdonor";
            this.lblDBdonor.Size = new System.Drawing.Size(75, 23);
            this.lblDBdonor.TabIndex = 14;
            // 
            // lblDBrecipient
            // 
            this.lblDBrecipient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "RECIPIENT", true));
            this.lblDBrecipient.Location = new System.Drawing.Point(63, 140);
            this.lblDBrecipient.Name = "lblDBrecipient";
            this.lblDBrecipient.Size = new System.Drawing.Size(75, 23);
            this.lblDBrecipient.TabIndex = 15;
            // 
            // lblDBscreened
            // 
            this.lblDBscreened.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "SCREENED", true));
            this.lblDBscreened.Location = new System.Drawing.Point(63, 166);
            this.lblDBscreened.Name = "lblDBscreened";
            this.lblDBscreened.Size = new System.Drawing.Size(75, 23);
            this.lblDBscreened.TabIndex = 16;
            // 
            // frmViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 452);
            this.Controls.Add(this.picDBclient);
            this.Controls.Add(this.lblDBscreened);
            this.Controls.Add(this.lblDBrecipient);
            this.Controls.Add(this.lblDBdonor);
            this.Controls.Add(this.lblImageLocation);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(lblIDnum);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRecordStatus);
            this.Controls.Add(this.lblDBOnline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewRecords";
            this.Text = "Kitra - View Records";
            this.Load += new System.EventHandler(this.frmViewRecords_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitraDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDBOnline;
        private System.Windows.Forms.Label lblRecordStatus;
        private System.Windows.Forms.Label lblDBlast;
        private System.Windows.Forms.Label lblBDfactor;
        private System.Windows.Forms.Label lblBDtype;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblDBcity;
        private System.Windows.Forms.Label lblDBstreet;
        private System.Windows.Forms.Label lblDBzip;
        private System.Windows.Forms.Label lblDBstate;
        private System.Windows.Forms.Label lblDBaddress;
        private System.Windows.Forms.Label lblDBfirst;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Label lblImageLocation;
        private System.Windows.Forms.PictureBox picDBclient;
        private System.Windows.Forms.Label lblDBphone;
        private System.Windows.Forms.CheckBox chkScreened;
        private System.Windows.Forms.CheckBox chkRecipient;
        private System.Windows.Forms.CheckBox chkDonor;
        private KitraDBDataSet kitraDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private KitraDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private KitraDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblDBscreened;
        private System.Windows.Forms.Label lblDBrecipient;
        private System.Windows.Forms.Label lblDBdonor;
    }
}