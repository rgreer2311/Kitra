namespace BloodBank
{
    partial class frmReviewRecords
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
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label sTREETLabel;
            System.Windows.Forms.Label cITYLabel;
            System.Windows.Forms.Label sTATELabel;
            System.Windows.Forms.Label zIPLabel;
            System.Windows.Forms.Label lblDonor;
            System.Windows.Forms.Label lblRecipient;
            System.Windows.Forms.Label lblTypr;
            System.Windows.Forms.Label lblRH;
            System.Windows.Forms.Label lblScreened;
            System.Windows.Forms.Label lblPhone;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviewRecords));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkScreened = new System.Windows.Forms.CheckBox();
            this.txtRH = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.chkRecipient = new System.Windows.Forms.CheckBox();
            this.chkDonor = new System.Windows.Forms.CheckBox();
            this.lblDBOnline = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRecordStatus = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitraDBDataSet = new BloodBank.KitraDBDataSet();
            this.clientsTableAdapter = new BloodBank.KitraDBDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new BloodBank.KitraDBDataSetTableAdapters.TableAdapterManager();
            this.picClient = new System.Windows.Forms.PictureBox();
            fNAMELabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            sTREETLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            sTATELabel = new System.Windows.Forms.Label();
            zIPLabel = new System.Windows.Forms.Label();
            lblDonor = new System.Windows.Forms.Label();
            lblRecipient = new System.Windows.Forms.Label();
            lblTypr = new System.Windows.Forms.Label();
            lblRH = new System.Windows.Forms.Label();
            lblScreened = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            this.grpData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).BeginInit();
            this.SuspendLayout();
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fNAMELabel.Location = new System.Drawing.Point(6, 26);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(50, 20);
            fNAMELabel.TabIndex = 7;
            fNAMELabel.Text = "First:";
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lNAMELabel.Location = new System.Drawing.Point(201, 26);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(49, 20);
            lNAMELabel.TabIndex = 8;
            lNAMELabel.Text = "Last:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aDDRESSLabel.Location = new System.Drawing.Point(9, 86);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(80, 20);
            aDDRESSLabel.TabIndex = 9;
            aDDRESSLabel.Text = "Address:";
            // 
            // sTREETLabel
            // 
            sTREETLabel.AutoSize = true;
            sTREETLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTREETLabel.Location = new System.Drawing.Point(9, 119);
            sTREETLabel.Name = "sTREETLabel";
            sTREETLabel.Size = new System.Drawing.Size(64, 20);
            sTREETLabel.TabIndex = 11;
            sTREETLabel.Text = "Street:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cITYLabel.Location = new System.Drawing.Point(12, 154);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(44, 20);
            cITYLabel.TabIndex = 13;
            cITYLabel.Text = "City:";
            // 
            // sTATELabel
            // 
            sTATELabel.AutoSize = true;
            sTATELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTATELabel.Location = new System.Drawing.Point(9, 187);
            sTATELabel.Name = "sTATELabel";
            sTATELabel.Size = new System.Drawing.Size(58, 20);
            sTATELabel.TabIndex = 15;
            sTATELabel.Text = "State:";
            // 
            // zIPLabel
            // 
            zIPLabel.AutoSize = true;
            zIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zIPLabel.Location = new System.Drawing.Point(13, 217);
            zIPLabel.Name = "zIPLabel";
            zIPLabel.Size = new System.Drawing.Size(39, 20);
            zIPLabel.TabIndex = 17;
            zIPLabel.Text = "Zip:";
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
            // lblTypr
            // 
            lblTypr.AutoSize = true;
            lblTypr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTypr.Location = new System.Drawing.Point(22, 26);
            lblTypr.Name = "lblTypr";
            lblTypr.Size = new System.Drawing.Size(52, 20);
            lblTypr.TabIndex = 4;
            lblTypr.Text = "Type:";
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
            lblPhone.Location = new System.Drawing.Point(8, 56);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(65, 20);
            lblPhone.TabIndex = 18;
            lblPhone.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Registration";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(743, 400);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 32);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(862, 25);
            this.clientsBindingNavigator.TabIndex = 6;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
            this.clientsBindingNavigator.RefreshItems += new System.EventHandler(this.clientsBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientsBindingNavigatorSaveItem.Text = "Save Data";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FNAME", true));
            this.txtFirst.Location = new System.Drawing.Point(95, 26);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "LNAME", true));
            this.txtLast.Location = new System.Drawing.Point(249, 26);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(115, 20);
            this.txtLast.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ADDRESS", true));
            this.txtAddress.Location = new System.Drawing.Point(95, 86);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(124, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "STREET", true));
            this.txtStreet.Location = new System.Drawing.Point(95, 121);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(176, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "CITY", true));
            this.txtCity.Location = new System.Drawing.Point(95, 156);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "STATE", true));
            this.txtState.Location = new System.Drawing.Point(95, 187);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(43, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtZip
            // 
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ZIP", true));
            this.txtZip.Location = new System.Drawing.Point(95, 219);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 7;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(lblPhone);
            this.grpData.Controls.Add(this.txtPhone);
            this.grpData.Controls.Add(fNAMELabel);
            this.grpData.Controls.Add(zIPLabel);
            this.grpData.Controls.Add(this.txtFirst);
            this.grpData.Controls.Add(this.txtZip);
            this.grpData.Controls.Add(this.txtLast);
            this.grpData.Controls.Add(sTATELabel);
            this.grpData.Controls.Add(lNAMELabel);
            this.grpData.Controls.Add(this.txtState);
            this.grpData.Controls.Add(this.txtAddress);
            this.grpData.Controls.Add(cITYLabel);
            this.grpData.Controls.Add(aDDRESSLabel);
            this.grpData.Controls.Add(this.txtCity);
            this.grpData.Controls.Add(this.txtStreet);
            this.grpData.Controls.Add(sTREETLabel);
            this.grpData.Location = new System.Drawing.Point(211, 96);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(371, 259);
            this.grpData.TabIndex = 19;
            this.grpData.TabStop = false;
            this.grpData.Text = "Client Data";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "PHONE", true));
            this.txtPhone.Location = new System.Drawing.Point(95, 56);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(lblScreened);
            this.groupBox1.Controls.Add(this.chkScreened);
            this.groupBox1.Controls.Add(lblRH);
            this.groupBox1.Controls.Add(this.txtRH);
            this.groupBox1.Controls.Add(lblTypr);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(lblRecipient);
            this.groupBox1.Controls.Add(this.chkRecipient);
            this.groupBox1.Controls.Add(lblDonor);
            this.groupBox1.Controls.Add(this.chkDonor);
            this.groupBox1.Location = new System.Drawing.Point(593, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 259);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Data";
            // 
            // chkScreened
            // 
            this.chkScreened.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "SCREENED", true));
            this.chkScreened.Location = new System.Drawing.Point(120, 147);
            this.chkScreened.Name = "chkScreened";
            this.chkScreened.Size = new System.Drawing.Size(30, 24);
            this.chkScreened.TabIndex = 4;
            this.chkScreened.UseVisualStyleBackColor = true;
            // 
            // txtRH
            // 
            this.txtRH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "RH_FACTOR", true));
            this.txtRH.Location = new System.Drawing.Point(125, 61);
            this.txtRH.Name = "txtRH";
            this.txtRH.Size = new System.Drawing.Size(100, 20);
            this.txtRH.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "BLOOD_TYPE", true));
            this.txtType.Location = new System.Drawing.Point(80, 28);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 0;
            // 
            // chkRecipient
            // 
            this.chkRecipient.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "SCREENED", true));
            this.chkRecipient.Location = new System.Drawing.Point(120, 119);
            this.chkRecipient.Name = "chkRecipient";
            this.chkRecipient.Size = new System.Drawing.Size(28, 24);
            this.chkRecipient.TabIndex = 3;
            this.chkRecipient.UseVisualStyleBackColor = true;
            // 
            // chkDonor
            // 
            this.chkDonor.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "DONOR", true));
            this.chkDonor.Location = new System.Drawing.Point(120, 92);
            this.chkDonor.Name = "chkDonor";
            this.chkDonor.Size = new System.Drawing.Size(30, 24);
            this.chkDonor.TabIndex = 2;
            this.chkDonor.UseVisualStyleBackColor = true;
            // 
            // lblDBOnline
            // 
            this.lblDBOnline.AutoSize = true;
            this.lblDBOnline.Location = new System.Drawing.Point(23, 419);
            this.lblDBOnline.Name = "lblDBOnline";
            this.lblDBOnline.Size = new System.Drawing.Size(0, 13);
            this.lblDBOnline.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(306, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(445, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 32);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoto.Location = new System.Drawing.Point(60, 364);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(107, 32);
            this.btnPhoto.TabIndex = 26;
            this.btnPhoto.Text = "&Add Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BloodBank.KitraDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picClient
            // 
            this.picClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClient.Location = new System.Drawing.Point(22, 96);
            this.picClient.Name = "picClient";
            this.picClient.Size = new System.Drawing.Size(179, 262);
            this.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClient.TabIndex = 27;
            this.picClient.TabStop = false;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 444);
            this.Controls.Add(this.picClient);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.lblRecordStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDBOnline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewRecords";
            this.Text = "Kitra - Registration";
            this.Load += new System.EventHandler(this.frmReviewRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private KitraDBDataSet kitraDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private KitraDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private KitraDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkScreened;
        private System.Windows.Forms.TextBox txtRH;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.CheckBox chkRecipient;
        private System.Windows.Forms.CheckBox chkDonor;
        private System.Windows.Forms.Label lblDBOnline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRecordStatus;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picClient;
    }
}