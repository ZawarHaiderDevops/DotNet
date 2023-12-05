using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATM_Management_System
{
    public partial class WithDraw : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int existingBalance;
        private int newBalance;
        public WithDraw()
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (amountTb.Text == "")
            {
                MessageBox.Show("please enter amount");
            }
            if (Convert.ToInt32(amountTb.Text) < 0)
            {
                MessageBox.Show("please enter valid amount");
            }
            else
            {
                string query = $"SELECT Balance FROM AccountTbl WHERE AccNum = '{LOGIN.AccNum}';";

                try
                {
                    OpenConnection();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    object result = cmd.ExecuteScalar();
                    existingBalance = Convert.ToInt32(result);

                    if (existingBalance < Convert.ToInt32(amountTb.Text))
                    {
                        MessageBox.Show("Not Engough Balance available in your account");
                    }
                    else
                    {
                        newBalance = existingBalance - Convert.ToInt32(amountTb.Text);

                        string updateBalanceQuery = $"Update AccountTbl set Balance = {newBalance} where AccNum = {LOGIN.AccNum};";
                        MySqlCommand ucmd = new MySqlCommand(updateBalanceQuery, connection);
                        ucmd.ExecuteNonQuery();

                        MessageBox.Show("Withrawl Successfull");

                        int amount = Convert.ToInt32(amountTb.Text);

                        string updateTransactionQuery = $"INSERT INTO TransactionTbl (AccNum, Type, Amount) VALUES ({LOGIN.AccNum},'withdraw',{amount});";

                        MySqlCommand tcmd = new MySqlCommand(updateTransactionQuery, connection); //transaction command
                        tcmd.ExecuteNonQuery();

                        amountTb.Text = "";

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
