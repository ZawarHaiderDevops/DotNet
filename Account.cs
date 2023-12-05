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
    public partial class Account : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Account()
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

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccNumtb.Text == "" || AccNametb.Text == "" || FaNametb.Text == "" || Addresstb.Text == "" || PhoneTb.Text == "" || Pintb.Text == "" || agetb.Text == "" || educationtb.Text == "" || Occupationtb.Text == "" || Citytb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    OpenConnection();
                    string query = $"Insert into AccountTbl values('{AccNumtb.Text}','{AccNametb.Text}','{FaNametb.Text}','{Addresstb.Text}','{PhoneTb.Text}','{Pintb.Text}','{agetb.Text}','{educationtb.Text}','{Occupationtb.Text}','{Citytb.Text}',0);";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully");


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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pintb_TextChanged(object sender, EventArgs e)
        {
            Pintb.PasswordChar = '*';
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
