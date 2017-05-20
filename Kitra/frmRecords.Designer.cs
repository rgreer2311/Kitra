namespace Kitra
{
    partial class frmRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecords));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnViewRecords = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(52, 218);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 31);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "&New Client";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnViewRecords
            // 
            this.btnViewRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRecords.Location = new System.Drawing.Point(163, 218);
            this.btnViewRecords.Name = "btnViewRecords";
            this.btnViewRecords.Size = new System.Drawing.Size(92, 31);
            this.btnViewRecords.TabIndex = 1;
            this.btnViewRecords.Text = "&View";
            this.btnViewRecords.UseVisualStyleBackColor = true;
            this.btnViewRecords.Click += new System.EventHandler(this.btnViewRecords_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(274, 218);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(92, 31);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnViewRecords);
            this.Controls.Add(this.btnRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecords";
            this.Text = "Kitra - Records Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnViewRecords;
        private System.Windows.Forms.Button btnHome;
    }
}