namespace Kitra
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
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
            this.btnRecords = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.grpData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            lNAMELabel.Location = new System.Drawing.Point(219, 26);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(49, 20);
            lNAMELabel.TabIndex = 8;
            lNAMELabel.Text = "Last:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aDDRESSLabel.Location = new System.Drawing.Point(6, 84);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(80, 20);
            aDDRESSLabel.TabIndex = 9;
            aDDRESSLabel.Text = "Address:";
            // 
            // sTREETLabel
            // 
            sTREETLabel.AutoSize = true;
            sTREETLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTREETLabel.Location = new System.Drawing.Point(6, 121);
            sTREETLabel.Name = "sTREETLabel";
            sTREETLabel.Size = new System.Drawing.Size(64, 20);
            sTREETLabel.TabIndex = 11;
            sTREETLabel.Text = "Street:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cITYLabel.Location = new System.Drawing.Point(6, 154);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(44, 20);
            cITYLabel.TabIndex = 13;
            cITYLabel.Text = "City:";
            // 
            // sTATELabel
            // 
            sTATELabel.AutoSize = true;
            sTATELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTATELabel.Location = new System.Drawing.Point(6, 185);
            sTATELabel.Name = "sTATELabel";
            sTATELabel.Size = new System.Drawing.Size(58, 20);
            sTATELabel.TabIndex = 15;
            sTATELabel.Text = "State:";
            // 
            // zIPLabel
            // 
            zIPLabel.AutoSize = true;
            zIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zIPLabel.Location = new System.Drawing.Point(6, 217);
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
            lblPhone.Location = new System.Drawing.Point(6, 54);
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
            // txtFirst
            // 
            this.txtFirst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirst.Location = new System.Drawing.Point(95, 26);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLast.Location = new System.Drawing.Point(267, 26);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(115, 20);
            this.txtLast.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 86);
            this.txtAddress.MaxLength = 6;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(124, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.Location = new System.Drawing.Point(95, 121);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(176, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.Location = new System.Drawing.Point(95, 156);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(95, 187);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(43, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(95, 219);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 7;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtPhone);
            this.grpData.Controls.Add(lblPhone);
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
            this.grpData.Size = new System.Drawing.Size(406, 259);
            this.grpData.TabIndex = 19;
            this.grpData.TabStop = false;
            this.grpData.Text = "Client Data";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 56);
            this.txtPhone.MaxLength = 10;
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
            this.groupBox1.Location = new System.Drawing.Point(623, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 259);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Data";
            // 
            // chkScreened
            // 
            this.chkScreened.Location = new System.Drawing.Point(125, 147);
            this.chkScreened.Name = "chkScreened";
            this.chkScreened.Size = new System.Drawing.Size(30, 24);
            this.chkScreened.TabIndex = 4;
            this.chkScreened.UseVisualStyleBackColor = true;
            // 
            // txtRH
            // 
            this.txtRH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRH.Location = new System.Drawing.Point(125, 61);
            this.txtRH.MaxLength = 3;
            this.txtRH.Name = "txtRH";
            this.txtRH.Size = new System.Drawing.Size(100, 20);
            this.txtRH.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtType.Location = new System.Drawing.Point(125, 28);
            this.txtType.MaxLength = 1;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 0;
            // 
            // chkRecipient
            // 
            this.chkRecipient.Location = new System.Drawing.Point(125, 119);
            this.chkRecipient.Name = "chkRecipient";
            this.chkRecipient.Size = new System.Drawing.Size(28, 24);
            this.chkRecipient.TabIndex = 3;
            this.chkRecipient.UseVisualStyleBackColor = true;
            // 
            // chkDonor
            // 
            this.chkDonor.Location = new System.Drawing.Point(125, 89);
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
            this.btnAdd.Location = new System.Drawing.Point(272, 364);
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
            this.btnPhoto.TabIndex = 0;
            this.btnPhoto.Text = "&Add Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Location = new System.Drawing.Point(620, 400);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(107, 32);
            this.btnRecords.TabIndex = 28;
            this.btnRecords.Text = "&Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.ClientSize = new System.Drawing.Size(889, 444);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.picClient);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.lblRecordStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDBOnline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistration";
            this.Text = "Kitra - Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
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
        private System.Windows.Forms.PictureBox picClient;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}