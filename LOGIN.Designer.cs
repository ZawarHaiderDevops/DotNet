namespace ATM_Management_System
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new Panel();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            SignUp = new Button();
            button1 = new Button();
            PinTb = new TextBox();
            AccNumTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 76);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(264, 80);
            label1.Name = "label1";
            label1.Size = new Size(124, 46);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.Green;
            SignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp.ForeColor = Color.White;
            SignUp.Location = new Point(318, 395);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(95, 40);
            SignUp.TabIndex = 14;
            SignUp.Text = "SIGN UP";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(318, 343);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(95, 44);
            button1.TabIndex = 13;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // PinTb
            // 
            PinTb.Location = new Point(360, 244);
            PinTb.Margin = new Padding(3, 4, 3, 4);
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(114, 27);
            PinTb.TabIndex = 12;
            PinTb.TextChanged += PinTb_TextChanged;
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(360, 171);
            AccNumTb.Margin = new Padding(3, 4, 3, 4);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(114, 27);
            AccNumTb.TabIndex = 11;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(249, 255);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 10;
            label4.Text = "PIN CODE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(249, 181);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 9;
            label3.Text = "Acc No.:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 171);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 485);
            Controls.Add(pictureBox1);
            Controls.Add(SignUp);
            Controls.Add(button1);
            Controls.Add(PinTb);
            Controls.Add(AccNumTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LOGIN";
            Text = "Form2";
            TopMost = true;
            Load += LOGIN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button SignUp;
        private Button button1;
        private TextBox PinTb;
        private TextBox AccNumTb;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button3;
    }
}