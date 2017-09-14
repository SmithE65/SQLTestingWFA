using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTestingWFA
{
    public partial class MainForm : Form
    {
        private SQLConnectDialog connectDialog;
        public string connString;
        private bool IsSqlConnected;

        public MainForm()
        {
            InitializeComponent();

            IsSqlConnected = false;

            connectDialog = new SQLConnectDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The connect or disconnect button has been clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SQLConnDisconn_Click(object sender, EventArgs e)
        {
            if (!IsSqlConnected)
                connectDialog.ShowDialog();
            else
            {
                SQLConnDisconn.Text = "Connect";
                ConnStatus.Text = "Disconnected";
                IsSqlConnected = false;
                CurrentDatabase.Items.Clear();
                CurrentTable.Items.Clear();
                DataTable table = (DataTable)dataGridView1.DataSource;
                if (table != null)
                    table.Dispose();
                dataGridView1.DataSource = null;
            }
        }

        /// <summary>
        /// Gets a list of databases from SQL Server and stores them in the CurrentDatabase dropdown
        /// </summary>
        private void GetDatabaseList()
        {
            // If we don't have a SQL connection, give up
            if (!IsSqlConnected)
                return;

            // clear the drop down box's contents
            CurrentDatabase.Items.Clear();

            // Get all the databases from SQL Server
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                DataTable schema = conn.GetSchema("Databases");
                List<string> result = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    result.Add(row[0].ToString());
                }

                // Put the list into the drop-down
                foreach (string dbName in result)
                {
                    CurrentDatabase.Items.Add(dbName);
                }
                CurrentDatabase.Text = conn.Database;//CurrentDatabase.Items[0].ToString();
                conn.Close();
            }
        }

        /// <summary>
        /// Gets a list of tables from the current database and stores them in the CurrentTable dropdown
        /// </summary>
        private void GetTableList()
        {
            // If we don't have a SQL connection, give up
            if (!IsSqlConnected)
                return;

            // clear the drop down box's contents
            CurrentTable.Items.Clear();

            // Get all the databases from SQL Server
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.ChangeDatabase(CurrentDatabase.Text);
                DataTable schema = conn.GetSchema("Tables");
                List<string> result = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    result.Add(row[2].ToString());
                }

                // Put the list into the drop-down
                foreach (string tblName in result)
                {
                    CurrentTable.Items.Add(tblName);
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Makes a test connection to SQL Server and calls GetDatabaseList(), if successful
        /// </summary>
        public void SqlConnect()
        {
            // TO-DO: ADD SQL Connection logic here
            ConnStatus.Text = "Connecting...";  // Update label
            SQLConnDisconn.Text = "Disconnect"; // Update button

            // Test the connection
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    ConnStatus.Text = "Connected";
                    IsSqlConnected = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;     // Something went wrong, get the hell out of here
                }

                try
                {
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;     // Something went wrong, get the hell out of here
                }
            }

            // Get ready to start doing stuff
            GetDatabaseList();
        }

        /// <summary>
        /// Called when user makes a selection in the CurrentDatabase dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentDatabase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!IsSqlConnected)
                return;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.ChangeDatabase(CurrentDatabase.Text);
                conn.Close();
            }

            GetTableList();
        }

        /// <summary>
        /// Called when user makes a selection in the CurrentTable dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Dispose of any existing table and get a new one
            string tableName = CurrentTable.Text;
            DataTable table = (DataTable)dataGridView1.DataSource;
            if (table != null)
            {
                table.Dispose();
            }
            table = new DataTable();

            // Get a SQL schema of all columns in current table
            DataTable schema = null;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.ChangeDatabase(CurrentDatabase.Text);  // Make sure we're in the right database

                string[] restrictions = new string[3];
                restrictions[2] = tableName;    // We want to restrict to current table only

                schema = conn.GetSchema("Columns", restrictions);

                conn.Close();   // Clean up
            }

            // Get all of our column names and associated datatypes
            List<string> dataTypes = new List<string>();
            foreach (DataRow row in schema.Rows)
            {
                table.Columns.Add(row[3].ToString(), tableName.GetType());  // Directly store our column names
                dataTypes.Add(row[7].ToString());
            }
            table.Rows.Add(dataTypes.ToArray());    // Put all the datatypes into the first row
            table.Rows.Add();

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // I haven't decided what to do here yet, so we do a popup telling the user how many cells have been selected
            int count = dataGridView1.SelectedCells.Count;
            MessageBox.Show($"{count} cell(s) selected.", "Test3");
        }
    }
}
