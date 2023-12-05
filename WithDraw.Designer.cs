namespace ATM_Management_System
{
    partial class WithDraw
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
            label1 = new Label();
            amountTb = new TextBox();
            button2 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 76);
            panel1.TabIndex = 39;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(521, 3);
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(535, 45);
            label2.TabIndex = 1;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(87, 201);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 44;
            label1.Text = "AMOUNT";
            // 
            // amountTb
            // 
            amountTb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            amountTb.Location = new Point(195, 199);
            amountTb.Margin = new Padding(3, 4, 3, 4);
            amountTb.Name = "amountTb";
            amountTb.Size = new Size(177, 27);
            amountTb.TabIndex = 43;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(235, 349);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(85, 45);
            button2.TabIndex = 42;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(212, 265);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(127, 45);
            button9.TabIndex = 40;
            button9.Text = "WITHDRAW";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // WithDraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 600);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(amountTb);
            Controls.Add(button2);
            Controls.Add(button9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WithDraw";
            Text = "WithDraw";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label2;
        private Label label1;
        private TextBox amountTb;
        private Button button2;
        private Button button9;
    }
}