using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();

            deposit.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mini_Statement mini_Statement = new Mini_Statement();

            mini_Statement.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();

            fastCash.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WithDraw withDraw = new WithDraw();

            withDraw.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Chnage_PIN chnage_PIN = new Chnage_PIN();

            chnage_PIN.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();

            balance.Show();

            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumText.Text = "Account Number:" + LOGIN.AccNum;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
