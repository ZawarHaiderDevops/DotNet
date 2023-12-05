namespace ATM_Management_System
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label88 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            AccNumtb = new TextBox();
            AccNametb = new TextBox();
            FaNametb = new TextBox();
            Addresstb = new TextBox();
            PhoneTb = new TextBox();
            Citytb = new TextBox();
            Occupationtb = new TextBox();
            agetb = new TextBox();
            Pintb = new TextBox();
            button1 = new Button();
            educationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 76);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(671, 7);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(30, 31);
            button3.TabIndex = 16;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 12);
            label2.Name = "label2";
            label2.Size = new Size(535, 45);
            label2.TabIndex = 1;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(56, 132);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 10;
            label3.Text = "Acc No.:";
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label88.ForeColor = Color.Black;
            label88.Location = new Point(337, 312);
            label88.Name = "label88";
            label88.Size = new Size(117, 23);
            label88.TabIndex = 11;
            label88.Text = "OCCUPATION";
            label88.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(56, 367);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 12;
            label4.Text = "PHONE";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(337, 256);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 13;
            label5.Text = "EDUCATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(337, 193);
            label6.Name = "label6";
            label6.Size = new Size(42, 23);
            label6.TabIndex = 14;
            label6.Text = "Age";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(337, 132);
            label7.Name = "label7";
            label7.Size = new Size(38, 23);
            label7.TabIndex = 15;
            label7.Text = "PIN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(56, 312);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 16;
            label8.Text = "ADDRESS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(56, 256);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 17;
            label9.Text = "FNAME";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(56, 193);
            label10.Name = "label10";
            label10.Size = new Size(60, 23);
            label10.TabIndex = 18;
            label10.Text = "NAME";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(337, 367);
            label11.Name = "label11";
            label11.Size = new Size(42, 23);
            label11.TabIndex = 19;
            label11.Text = "City";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.AppWorkspace;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(304, 528);
            label12.Name = "label12";
            label12.Size = new Size(89, 28);
            label12.TabIndex = 21;
            label12.Text = "Go Back";
            label12.Click += label12_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(0, 587);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 13);
            panel2.TabIndex = 17;
            // 
            // AccNumtb
            // 
            AccNumtb.Location = new Point(144, 124);
            AccNumtb.Margin = new Padding(3, 4, 3, 4);
            AccNumtb.Name = "AccNumtb";
            AccNumtb.Size = new Size(140, 27);
            AccNumtb.TabIndex = 22;
            // 
            // AccNametb
            // 
            AccNametb.Location = new Point(144, 185);
            AccNametb.Margin = new Padding(3, 4, 3, 4);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(140, 27);
            AccNametb.TabIndex = 23;
            // 
            // FaNametb
            // 
            FaNametb.Location = new Point(144, 248);
            FaNametb.Margin = new Padding(3, 4, 3, 4);
            FaNametb.Name = "FaNametb";
            FaNametb.Size = new Size(140, 27);
            FaNametb.TabIndex = 24;
            // 
            // Addresstb
            // 
            Addresstb.Location = new Point(144, 304);
            Addresstb.Margin = new Padding(3, 4, 3, 4);
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(140, 27);
            Addresstb.TabIndex = 25;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(144, 359);
            PhoneTb.Margin = new Padding(3, 4, 3, 4);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(140, 27);
            PhoneTb.TabIndex = 26;
            PhoneTb.TextChanged += textBox5_TextChanged;
            // 
            // Citytb
            // 
            Citytb.Location = new Point(449, 363);
            Citytb.Margin = new Padding(3, 4, 3, 4);
            Citytb.Name = "Citytb";
            Citytb.Size = new Size(140, 27);
            Citytb.TabIndex = 31;
            // 
            // Occupationtb
            // 
            Occupationtb.Location = new Point(449, 304);
            Occupationtb.Margin = new Padding(3, 4, 3, 4);
            Occupationtb.Name = "Occupationtb";
            Occupationtb.Size = new Size(140, 27);
            Occupationtb.TabIndex = 30;
            Occupationtb.TextChanged += textBox7_TextChanged;
            // 
            // agetb
            // 
            agetb.Location = new Point(449, 185);
            agetb.Margin = new Padding(3, 4, 3, 4);
            agetb.Name = "agetb";
            agetb.Size = new Size(140, 27);
            agetb.TabIndex = 28;
            // 
            // Pintb
            // 
            Pintb.Location = new Point(449, 124);
            Pintb.Margin = new Padding(3, 4, 3, 4);
            Pintb.Name = "Pintb";
            Pintb.Size = new Size(140, 27);
            Pintb.TabIndex = 27;
            Pintb.TextChanged += Pintb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(274, 467);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 41);
            button1.TabIndex = 32;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // educationtb
            // 
            educationtb.Location = new Point(449, 254);
            educationtb.Margin = new Padding(3, 4, 3, 4);
            educationtb.Name = "educationtb";
            educationtb.Size = new Size(140, 27);
            educationtb.TabIndex = 33;
            educationtb.TextChanged += textBox1_TextChanged;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 600);
            Controls.Add(educationtb);
            Controls.Add(button1);
            Controls.Add(Citytb);
            Controls.Add(Occupationtb);
            Controls.Add(agetb);
            Controls.Add(Pintb);
            Controls.Add(PhoneTb);
            Controls.Add(Addresstb);
            Controls.Add(FaNametb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumtb);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label88);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label88;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private TextBox AccNumtb;
        private TextBox AccNametb;
        private TextBox FaNametb;
        private TextBox Addresstb;
        private TextBox PhoneTb;
        private TextBox Citytb;
        private TextBox Occupationtb;
        private TextBox agetb;
        private TextBox Pintb;
        private Button button1;
        private TextBox educationtb;
    }
}