namespace WinFormsApp2
{
    partial class AddStudent
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
            tb6 = new TextBox();
            tb5 = new TextBox();
            tb3 = new TextBox();
            tb2 = new TextBox();
            tb1 = new TextBox();
            bt1 = new Button();
            lb6 = new Label();
            lb5 = new Label();
            lb4 = new Label();
            lb3 = new Label();
            lb2 = new Label();
            lb1 = new Label();
            pn1 = new Panel();
            tb4 = new TextBox();
            pb1 = new PictureBox();
            bt2 = new Button();
            bt3 = new Button();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // tb6
            // 
            tb6.BackColor = SystemColors.Window;
            tb6.Location = new Point(309, 220);
            tb6.Name = "tb6";
            tb6.Size = new Size(136, 23);
            tb6.TabIndex = 31;
            // 
            // tb5
            // 
            tb5.BackColor = SystemColors.Window;
            tb5.Location = new Point(58, 220);
            tb5.Name = "tb5";
            tb5.Size = new Size(133, 23);
            tb5.TabIndex = 30;
            // 
            // tb3
            // 
            tb3.BackColor = SystemColors.Window;
            tb3.Location = new Point(58, 146);
            tb3.Name = "tb3";
            tb3.Size = new Size(133, 23);
            tb3.TabIndex = 29;
            // 
            // tb2
            // 
            tb2.BackColor = SystemColors.Window;
            tb2.Location = new Point(309, 67);
            tb2.Name = "tb2";
            tb2.Size = new Size(136, 23);
            tb2.TabIndex = 28;
            // 
            // tb1
            // 
            tb1.BackColor = SystemColors.Window;
            tb1.Location = new Point(58, 67);
            tb1.Name = "tb1";
            tb1.Size = new Size(133, 23);
            tb1.TabIndex = 27;
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(168, 274);
            bt1.Name = "bt1";
            bt1.Size = new Size(154, 61);
            bt1.TabIndex = 26;
            bt1.Text = "SAVE";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb6.Location = new Point(322, 167);
            lb6.Name = "lb6";
            lb6.Size = new Size(110, 50);
            lb6.TabIndex = 25;
            lb6.Text = "Email";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb5.Location = new Point(49, 172);
            lb5.Name = "lb5";
            lb5.Size = new Size(150, 50);
            lb5.TabIndex = 24;
            lb5.Text = "Contact";
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb4.Location = new Point(330, 93);
            lb4.Name = "lb4";
            lb4.Size = new Size(94, 50);
            lb4.TabIndex = 23;
            lb4.Text = "SEM";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.Location = new Point(15, 93);
            lb3.Name = "lb3";
            lb3.Size = new Size(219, 50);
            lb3.TabIndex = 22;
            lb3.Text = "Department";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.Location = new Point(247, 14);
            lb2.Name = "lb2";
            lb2.Size = new Size(260, 50);
            lb2.TabIndex = 21;
            lb2.Text = "Enrollment No";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(64, 14);
            lb1.Name = "lb1";
            lb1.Size = new Size(120, 50);
            lb1.TabIndex = 20;
            lb1.Text = "Name";
            // 
            // pn1
            // 
            pn1.Controls.Add(tb4);
            pn1.Controls.Add(lb1);
            pn1.Controls.Add(lb2);
            pn1.Controls.Add(tb6);
            pn1.Controls.Add(lb3);
            pn1.Controls.Add(tb5);
            pn1.Controls.Add(lb4);
            pn1.Controls.Add(tb3);
            pn1.Controls.Add(lb5);
            pn1.Controls.Add(tb2);
            pn1.Controls.Add(lb6);
            pn1.Controls.Add(tb1);
            pn1.Controls.Add(bt1);
            pn1.Location = new Point(12, 217);
            pn1.Name = "pn1";
            pn1.Size = new Size(521, 352);
            pn1.TabIndex = 33;
            // 
            // tb4
            // 
            tb4.BackColor = SystemColors.Window;
            tb4.Location = new Point(309, 146);
            tb4.Name = "tb4";
            tb4.ShortcutsEnabled = false;
            tb4.Size = new Size(136, 23);
            tb4.TabIndex = 32;
            // 
            // pb1
            // 
            pb1.Location = new Point(180, 12);
            pb1.Name = "pb1";
            pb1.Size = new Size(178, 170);
            pb1.TabIndex = 34;
            pb1.TabStop = false;
            pb1.Click += Pb1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(180, 188);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 23);
            bt2.TabIndex = 36;
            bt2.Text = "Upload";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += Bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(283, 188);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 23);
            bt3.TabIndex = 37;
            bt3.Text = "Clear";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += Bt3_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 579);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(pb1);
            Controls.Add(pn1);
            Name = "AddStudent";
            Text = "AddStudent";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tb6;
        private TextBox tb5;
        private TextBox tb3;
        private TextBox tb2;
        private TextBox tb1;
        private Button bt1;
        private Label lb6;
        private Label lb5;
        private Label lb4;
        private Label lb3;
        private Label lb2;
        private Label lb1;
        private Panel pn1;
        private PictureBox pb1;
        private TextBox tb4;
        private Button bt2;
        private Button bt3;
    }
}