namespace ATM_Management_System
{
    partial class Mini_Statement
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
            label12 = new Label();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 76);
            panel1.TabIndex = 34;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(244, 563);
            label12.Name = "label12";
            label12.Size = new Size(64, 28);
            label12.TabIndex = 35;
            label12.Text = "BACK";
            label12.Click += label12_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(154, 85);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(222, 45);
            button9.TabIndex = 39;
            button9.Text = "MINI STATEMENT";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 139);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(561, 417);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Mini_Statement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 600);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(label12);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mini_Statement";
            Text = "Mini_Statement";
            Load += Mini_Statement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label2;
        private Label label12;
        private Button button9;
        private DataGridView dataGridView1;
    }
}