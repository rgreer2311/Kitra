namespace Kitra
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitraDBDataSet = new Kitra.KitraDBDataSet();
            this.clientsTableAdapter = new Kitra.KitraDBDataSetTableAdapters.ClientsTableAdapter();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(712, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(153, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Quick Search";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1458, 425);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 32);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "A Pos Match",
            "A Neg Match",
            "AB Pos Match",
            "AB Neg Match",
            "B Pos Match",
            "B Neg Match",
            "O Pos Match",
            "O Neg Match"});
            this.cboSearch.Location = new System.Drawing.Point(701, 37);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(175, 21);
            this.cboSearch.TabIndex = 7;
            this.cboSearch.Text = "Select Query";
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.kitraDBDataSet;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 66);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(1553, 353);
            this.dgvResults.TabIndex = 8;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 469);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Kitra - Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnHome;
        private KitraDBDataSet kitraDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private KitraDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}