namespace ATM_Management_System
{
    partial class Balance
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
            BalanceText = new Button();
            AccNumText = new Button();
            button2 = new Button();
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
            panel1.Size = new Size(561, 76);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(522, 4);
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
            label2.Location = new Point(25, 17);
            label2.Name = "label2";
            label2.Size = new Size(535, 45);
            label2.TabIndex = 1;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            label2.Click += label2_Click;
            // 
            // BalanceText
            // 
            BalanceText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceText.Location = new Point(141, 208);
            BalanceText.Margin = new Padding(3, 4, 3, 4);
            BalanceText.Name = "BalanceText";
            BalanceText.Size = new Size(281, 45);
            BalanceText.TabIndex = 29;
            BalanceText.Text = "Your Balance is: ";
            BalanceText.UseVisualStyleBackColor = true;
            BalanceText.Click += button9_Click;
            // 
            // AccNumText
            // 
            AccNumText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AccNumText.Location = new Point(141, 127);
            AccNumText.Margin = new Padding(3, 4, 3, 4);
            AccNumText.Name = "AccNumText";
            AccNumText.Size = new Size(281, 45);
            AccNumText.TabIndex = 30;
            AccNumText.Text = "Account Number: ";
            AccNumText.UseVisualStyleBackColor = true;
            AccNumText.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(232, 345);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(85, 45);
            button2.TabIndex = 31;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 473);
            Controls.Add(button2);
            Controls.Add(AccNumText);
            Controls.Add(BalanceText);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Balance";
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label2;
        private Button BalanceText;
        private Button AccNumText;
        private Button button2;
    }
}