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
                dataGridView1.DataSource = null;
            }
        }

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

        private void CurrentTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string tableName = CurrentTable.Text;
            DataTable table = new DataTable(tableName);
            DataTable schema = null;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.ChangeDatabase(CurrentDatabase.Text);

                string[] restrictions = new string[3];
                restrictions[2] = tableName;

                schema = conn.GetSchema("Columns", restrictions);

                conn.Close();
            }

            List<string> dataTypes = new List<string>();
            foreach (DataRow row in schema.Rows)
            {
                table.Columns.Add(row[3].ToString(), tableName.GetType());
                dataTypes.Add(row[7].ToString());
            }

            object[] o = new object[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                o[i] = dataTypes[i];
            }
            table.Rows.Add(o);

            dataGridView1.DataSource = table;
        }
    }
}
