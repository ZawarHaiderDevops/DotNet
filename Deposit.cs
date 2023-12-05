using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATM_Management_System
{
    public partial class Deposit : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Deposit()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            server = "127.0.0.1";
            database = "Atm_db";
            uid = "root";
            password = "root";

            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();

            home.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DepositTb.Text == "")
            {
                MessageBox.Show("please enter deposit amout");
            }

            if (Convert.ToInt32(DepositTb.Text) < 0)
            {
                MessageBox.Show("please enter a valid deposit amout");
            }

            else
            {
                try
                {
                    OpenConnection();

                    string balanceQuery = $"SELECT Balance FROM AccountTbl WHERE AccNum = '{LOGIN.AccNum}';";

                    MySqlCommand bcmd = new MySqlCommand(balanceQuery, connection);
                    object result = bcmd.ExecuteScalar();

                    string query = $"UPDATE AccountTbl set Balance = {DepositTb.Text} + {result} where AccNum = {LOGIN.AccNum};";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Balance Updated Successfully");

                    int amount = Convert.ToInt32(DepositTb.Text);

                    string updateTransactionQuery = $"INSERT INTO TransactionTbl (AccNum, Type, Amount) VALUES ({LOGIN.AccNum},'deposit',{amount});";

                    MySqlCommand tcmd = new MySqlCommand(updateTransactionQuery, connection); //transaction command
                    tcmd.ExecuteNonQuery();

                    DepositTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }
    }
}
