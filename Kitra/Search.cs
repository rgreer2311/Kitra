// frmSearch

// This form allows the user to select a quick query from the combobox for matching blood types
using System;
using System.Windows.Forms;

namespace Kitra
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   // Returns to the Home form
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On selection of a query type from the combobox the query type is set in the Utility class.
            // The searchRecords method then returns the results for the selected query to the data grid.
                
            Utility qRecords = new Utility();
            // Map query to cboSearch index
            if (cboSearch.SelectedIndex == 0)
                qRecords.queryType = qRecords.aPosQuery;
            if (cboSearch.SelectedIndex == 1)
                qRecords.queryType = qRecords.aNegQuery;
            if (cboSearch.SelectedIndex == 2)
                qRecords.queryType = qRecords.abPosQuery;
            if (cboSearch.SelectedIndex == 3)
                qRecords.queryType = qRecords.abNegQuery;
            if (cboSearch.SelectedIndex == 4)
                qRecords.queryType = qRecords.bPosQuery;
            if (cboSearch.SelectedIndex == 5)
                qRecords.queryType = qRecords.bNegQuery;
            if (cboSearch.SelectedIndex == 6)
                qRecords.queryType = qRecords.oPosQuery;
            if (cboSearch.SelectedIndex == 7)
                qRecords.queryType = qRecords.oNegQuery;
            // Call SearchRecords to query the database
            qRecords.SearchRecords();
            // Set datagrid view datasource to selected record set.
            dgvResults.DataSource = qRecords.dsClients.Tables[0];
        }
    }
}
