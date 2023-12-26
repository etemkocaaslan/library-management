namespace WinFormsApp2
{
    partial class ReturnBook
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
            pn2 = new Panel();
            dtp1 = new DateTimePicker();
            lb9 = new Label();
            lb7 = new Label();
            bt3 = new Button();
            lb5 = new Label();
            lb6 = new Label();
            lb3 = new Label();
            dgw1 = new DataGridView();
            bt1 = new Button();
            tb1 = new TextBox();
            lb1 = new Label();
            pn1 = new Panel();
            lb8 = new Label();
            lb4 = new Label();
            pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw1).BeginInit();
            pn1.SuspendLayout();
            SuspendLayout();
            // 
            // pn2
            // 
            pn2.BackColor = SystemColors.Control;
            pn2.Controls.Add(lb8);
            pn2.Controls.Add(dtp1);
            pn2.Controls.Add(lb9);
            pn2.Controls.Add(lb4);
            pn2.Controls.Add(lb7);
            pn2.Controls.Add(bt3);
            pn2.Controls.Add(lb5);
            pn2.Controls.Add(lb6);
            pn2.Controls.Add(lb3);
            pn2.Location = new Point(263, 220);
            pn2.Name = "pn2";
            pn2.Size = new Size(430, 239);
            pn2.TabIndex = 9;
            pn2.Tag = "";
            pn2.Visible = false;
            // 
            // dtp1
            // 
            dtp1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtp1.Location = new Point(173, 140);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(172, 27);
            dtp1.TabIndex = 39;
            // 
            // lb9
            // 
            lb9.AutoSize = true;
            lb9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb9.Location = new Point(173, 98);
            lb9.Name = "lb9";
            lb9.Size = new Size(56, 30);
            lb9.TabIndex = 38;
            lb9.Text = "NaN";
            // 
            // lb7
            // 
            lb7.AutoSize = true;
            lb7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb7.Location = new Point(173, 38);
            lb7.Name = "lb7";
            lb7.Size = new Size(56, 30);
            lb7.TabIndex = 36;
            lb7.Text = "NaN";
            // 
            // bt3
            // 
            bt3.BackColor = SystemColors.ActiveCaption;
            bt3.FlatAppearance.BorderColor = Color.Silver;
            bt3.FlatAppearance.BorderSize = 5;
            bt3.FlatStyle = FlatStyle.Popup;
            bt3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt3.Location = new Point(166, 185);
            bt3.Name = "bt3";
            bt3.Size = new Size(109, 48);
            bt3.TabIndex = 32;
            bt3.Text = "RETURN";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += Bt3_Click;
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb5.Location = new Point(54, 98);
            lb5.Name = "lb5";
            lb5.Size = new Size(113, 30);
            lb5.TabIndex = 22;
            lb5.Text = "Issue Date";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb6.Location = new Point(30, 137);
            lb6.Name = "lb6";
            lb6.Size = new Size(137, 30);
            lb6.TabIndex = 21;
            lb6.Text = "Select a date";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb3.Location = new Point(39, 38);
            lb3.Name = "lb3";
            lb3.Size = new Size(128, 30);
            lb3.TabIndex = 20;
            lb3.Text = "Book Name";
            // 
            // dgw1
            // 
            dgw1.AllowUserToAddRows = false;
            dgw1.BackgroundColor = SystemColors.ControlLight;
            dgw1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw1.Location = new Point(263, 12);
            dgw1.Name = "dgw1";
            dgw1.RowTemplate.Height = 40;
            dgw1.RowTemplate.Resizable = DataGridViewTriState.True;
            dgw1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw1.Size = new Size(676, 202);
            dgw1.TabIndex = 7;
            dgw1.CellClick += Dgw1_CellClick;
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(86, 111);
            bt1.Name = "bt1";
            bt1.Size = new Size(65, 27);
            bt1.TabIndex = 13;
            bt1.Text = "SEARCH";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb1.Location = new Point(54, 78);
            tb1.Name = "tb1";
            tb1.Size = new Size(128, 29);
            tb1.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(45, 45);
            lb1.Name = "lb1";
            lb1.Size = new Size(147, 30);
            lb1.TabIndex = 0;
            lb1.Text = "Enrollment No";
            // 
            // pn1
            // 
            pn1.BackColor = SystemColors.ControlLight;
            pn1.Controls.Add(bt1);
            pn1.Controls.Add(tb1);
            pn1.Controls.Add(lb1);
            pn1.Location = new Point(12, 12);
            pn1.Name = "pn1";
            pn1.Size = new Size(245, 202);
            pn1.TabIndex = 8;
            // 
            // lb8
            // 
            lb8.AutoSize = true;
            lb8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb8.Location = new Point(173, 68);
            lb8.Name = "lb8";
            lb8.Size = new Size(56, 30);
            lb8.TabIndex = 41;
            lb8.Text = "NaN";
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb4.Location = new Point(75, 68);
            lb4.Name = "lb4";
            lb4.Size = new Size(92, 30);
            lb4.TabIndex = 40;
            lb4.Text = "Book ID";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 465);
            Controls.Add(pn1);
            Controls.Add(pn2);
            Controls.Add(dgw1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw1).EndInit();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tb8;
        private Panel pn2;
        private TextBox tb6;
        private TextBox tb7;
        private Label lb9;
        private Label lb7;
        private DataGridView dgw1;
        private Button bt1;
        private TextBox tb1;
        private Label lb1;
        private Panel pn1;
        private Label label1;
        private Label label2;
        private Label LB6;
        private Button bt3;
        private Label lb5;
        private Label lb6;
        private Label lb3;
        private DateTimePicker dtp1;
        private Label lb8;
        private Label lb4;
    }
}