using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace DBConnection
{
    public partial class db : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");
        public db()
        {
            InitializeComponent();
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);

        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if(settings != null)
                returnValue = settings.ConnectionString;
                return returnValue;
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectToDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectFromDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=WIN-22";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Connection was established successfully");
                }
                else
                {
                    MessageBox.Show("Connection was already established");
                }
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "SQL Error code " + se.NativeError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Connection was closed");
            }
            else
            {
                MessageBox.Show("Connection was already closed");
            }
        }

        private void listOfConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach(ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("Provider Name = " + cs.ProviderName);
                    MessageBox.Show("Connection String = " + cs.ConnectionString);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State==ConnectionState.Closed)
            {
                MessageBox.Show("Connect to the Database first");
                return;
            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Select Count(*) from Products";
            int number=(int)command.ExecuteScalar();
            label1.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(connection.State==ConnectionState.Closed)
            {
                MessageBox.Show("Connect to the Database first");
                return;
            }
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "Select ProductName from Products";
            OleDbDataReader reader=command.ExecuteReader();
            while(reader.Read())
            {
                listView1.Items.Add(reader["ProductName"].ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection connection=new OleDbConnection(testConnect);
            connection.Open();
            OleDbTransaction OleTran=connection.BeginTransaction();
            OleDbCommand command = connection.CreateCommand();
            command.Transaction = OleTran;
            try
            {
                command.CommandText = "Insert into Products (ProductName) Values('Wrong Size')";
                command.ExecuteNonQuery();
                command.CommandText = "Insert into Products (ProductName) Values('Wrong Color')";
                command.ExecuteNonQuery();
                OleTran.Commit();
                MessageBox.Show("Both records were written to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    OleTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    MessageBox.Show(exRollback.Message);
                }
            }
            connection.Close();
        }
    }
}
