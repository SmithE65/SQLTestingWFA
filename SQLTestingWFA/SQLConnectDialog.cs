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
    public partial class SQLConnectDialog : Form
    {
        MainForm myParent;

        public SQLConnectDialog()
        {
            InitializeComponent();
        }

        public SQLConnectDialog(MainForm parentForm)
        {
            InitializeComponent();

            myParent = parentForm;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            // TO-DO: build the connection string here
            string IsTrustedConnection;
            if (TrustedConnectionCheck.Checked)
                IsTrustedConnection = "yes";
            else
                IsTrustedConnection = "no";

            myParent.connString = $"user id={UserIdTextBox.Text};" +
                                    $"password={PasswordTextBox.Text};" +
                                    $"Server={ServerTextBox.Text};" +
                                    $"Trusted_Connection={IsTrustedConnection};" +
                                    "connection timeout=30";
            myParent.SqlConnect();
            this.Close();
        }
    }
}
