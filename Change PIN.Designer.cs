namespace ATM_Management_System
{
    partial class Chnage_PIN
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
            label4 = new Label();
            newPinTb = new TextBox();
            confirmPinTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button9 = new Button();
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
            panel1.TabIndex = 33;
            // 
            // button3
            // 
            button3.Location = new Point(528, 3);
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
            label2.Location = new Point(24, 15);
            label2.Name = "label2";
            label2.Size = new Size(535, 45);
            label2.TabIndex = 1;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(155, 219);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 18;
            label3.Text = "New PIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(155, 292);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 19;
            label4.Text = "Confirm PIN";
            // 
            // newPinTb
            // 
            newPinTb.Location = new Point(266, 208);
            newPinTb.Margin = new Padding(3, 4, 3, 4);
            newPinTb.Name = "newPinTb";
            newPinTb.Size = new Size(114, 27);
            newPinTb.TabIndex = 20;
            // 
            // confirmPinTb
            // 
            confirmPinTb.Location = new Point(266, 281);
            confirmPinTb.Margin = new Padding(3, 4, 3, 4);
            confirmPinTb.Name = "confirmPinTb";
            confirmPinTb.Size = new Size(114, 27);
            confirmPinTb.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(224, 373);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(95, 44);
            button1.TabIndex = 22;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(224, 425);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(95, 40);
            button2.TabIndex = 23;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(179, 117);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(222, 45);
            button9.TabIndex = 38;
            button9.Text = "CHANGE YOUR PIN CODE";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Chnage_PIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 600);
            Controls.Add(button9);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(confirmPinTb);
            Controls.Add(newPinTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chnage_PIN";
            Text = " ";
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
        private Label label4;
        private TextBox newPinTb;
        private TextBox confirmPinTb;
        private Button button1;
        private Button button2;
        private Button button9;
    }
}