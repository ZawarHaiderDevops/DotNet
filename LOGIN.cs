using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATM_Management_System
{
    public partial class LOGIN : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public static int AccNum;
        public LOGIN()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = $"SELECT COUNT(*) FROM AccountTbl WHERE AccNum = '{AccNumTb.Text}' AND PIN = '{PinTb.Text}'";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    HOME home = new HOME();

                    AccNum = Convert.ToInt32(AccNumTb.Text);

                    home.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong PIN or Account Number");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Account account = new Account();

            account.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {
            PinTb.PasswordChar = '*';
        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
