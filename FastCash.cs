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
using MySql.Data.MySqlClient;

namespace ATM_Management_System
{
    public partial class FastCash : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int existingBalance;
        private int newBalance;

        public FastCash()
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


        private void button7_Click(object sender, EventArgs e)
        {
            withdrawAmount(500);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();

            home.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            withdrawAmount(100);
        }

        private void withdrawAmount(int amount)
        {
            string query = $"SELECT Balance FROM AccountTbl WHERE AccNum = '{LOGIN.AccNum}';";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                object result = cmd.ExecuteScalar();
                existingBalance = Convert.ToInt32(result);

                if (existingBalance < amount)
                {
                    MessageBox.Show("Not Engough Balance available in your account");
                }
                else
                {
                    newBalance = existingBalance - amount;

                    string updateBalanceQuery = $"Update AccountTbl set Balance = {newBalance} where AccNum = {LOGIN.AccNum};";
                    MySqlCommand ucmd = new MySqlCommand(updateBalanceQuery, connection);
                    ucmd.ExecuteNonQuery();

                    MessageBox.Show("Withrawl Successfull");

                    string updateTransactionQuery = $"INSERT INTO TransactionTbl (AccNum, Type, Amount) VALUES ({LOGIN.AccNum},'withdraw',{amount});";

                    MySqlCommand tcmd = new MySqlCommand(updateTransactionQuery, connection); //transaction command
                    tcmd.ExecuteNonQuery();
                }
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

        private void button6_Click(object sender, EventArgs e)
        {
            withdrawAmount(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withdrawAmount(2000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            withdrawAmount(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdrawAmount(10000);
        }
    }
}
