// Roger Greer
// Programming in C# 
// Course Project
// Class Utility.cs
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


// This class contains the database logic for the Kitra Blood Bank software. It accesses the MS Access "KitraDB" database.
namespace Kitra
{   
    class Utility
    {
        // SQL strings are private parameterized string variables with public get accessors.
        private string dbConnection = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=";
        private string selectAll = "SELECT * FROM clients";
        private string aPos = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'A' AND RH_FACTOR = 'POS'";
        private string aNeg = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'A' AND RH_FACTOR = 'NEG'";
        private string abPos = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'AB' AND RH_FACTOR = 'POS'";
        private string abNeg = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'AB' AND RH_FACTOR = 'NEG'";
        private string bPos = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'B' AND RH_FACTOR = 'POS'";
        private string bNeg = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'B' AND RH_FACTOR = 'NEG'";
        private string oPos = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'O' AND RH_FACTOR = 'POS'";
        private string oNeg = "SELECT * FROM CLIENTS WHERE BLOOD_TYPE = 'O' AND RH_FACTOR = 'NEG'";
        private string cDonor = "SELECT * FROM CLIENTS WHERE [DONOR] = 'True'";
        private string cRecipient = "SELECT * FROM CLIENTS WHERE [RECIPIENT] = 'True'";
        private string cScreened = "SELECT * FROM CLIENTS WHERE [SCREENED] = 'True'";
        private string addRecord;
        // Public accessors for private database variables and SQL querries.
        public string connParam
        {
            get
            {
                return dbConnection;
            }
        }
        public string queryAll
        {
            get
            {
                return selectAll;
            }
        }
        public string first {get; set;}
        public string last {get; set;}
        public long phone {get; set;}
        public long address {get; set;}
        public string street {get; set;}
        public string city {get; set;}
        public string state {get; set;}
        public int zip {get; set;}
        public string type {get; set;}
        public string factor {get; set;}
        public string photo {get; set;}
        public int donor {get; set;}
        public int recipient { get; set;}
        public int screened { get; set;}
        public string insertRecord
        {
            get
            {
                return addRecord = "insert into clients(FNAME, LNAME, PHONE, ADDRESS, STREET, CITY, STATE, ZIP, BLOOD_TYPE, RH_FACTOR, SCREENED, DONOR, RECIPIENT,[IMAGE]) values('" + first + "','" + last + "', '" + phone + "', '" + address + "', '" + street + "', '" + city + "', '" + state + "', '" + zip + "','" + type + "', '" + factor + "', " + screened + ", " + donor + ", " + recipient + ",'" + photo + "')"; 
            }
        }
        public string aPosQuery
        {
            get
            {
                return aPos;
            }
        }
        public string aNegQuery
        {
            get
            {
                return aNeg;
            }
        }
        public string abPosQuery
        {
            get
            {
                return abPos;
            }
        }
        public string abNegQuery
        {
            get
            {
                return abNeg;
            }
        }
        public string bPosQuery
        {
            get
            {
                return bPos;
            }
        }
        public string bNegQuery
        {
            get
            {
                return bNeg;
            }
        }
        public string oPosQuery
        {
            get
            {
                return oPos;
            }
        }
        public string oNegQuery
        {
            get
            {
                return oNeg;
            }
        }
        public string donorQuery
        {
            get
            {
                return cDonor;
            }
        }
        public string recipientQuery
        {
            get
            {
                return cRecipient;
            }
        }
        public string screenedQuery
        {
            get
            {
                return cScreened;
            }
        }
        public string queryType { get; set; }
        // Public dataset for querry results, may violate good security practice rules.
        public DataSet dsClients = new DataSet();

        public void AddClient()
        // This method accepts input via public accessors from "frmRegistration" and inserts client records into the database.
        {
            OleDbConnection dbConnection = new OleDbConnection(connParam);
            OleDbCommand oleDBcommand = new OleDbCommand(insertRecord, dbConnection);
            try
            {
                dbConnection.Open();
                int temp = oleDBcommand.ExecuteNonQuery();
                if (temp > 0)
                    MessageBox.Show("Client Record Added", "Success", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Client Record Addition was Unsuccessful", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void SearchRecords()
        // This method is accessed from "frmSearch" and executes querries based on a selected query. The results are put into the public "dsClients" dataset. 
        {
            OleDbConnection dbConnection = new OleDbConnection(connParam);
            
            try
            {
                dbConnection.Open();
                OleDbDataAdapter dtAdapter = new OleDbDataAdapter(queryType, dbConnection);
                dtAdapter.Fill(dsClients); 
            }

            catch
            {
                MessageBox.Show("Database is unavailable", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            finally
            {
                dbConnection.Close();
            }
        }
    }
}
