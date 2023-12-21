namespace WinFormsApp2
{
    partial class IssueBook
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
            pn1 = new Panel();
            bt2 = new Button();
            lbx1 = new ListBox();
            tb2 = new TextBox();
            lb3 = new Label();
            dtp1 = new DateTimePicker();
            lb2 = new Label();
            bt1 = new Button();
            tb1 = new TextBox();
            lb1 = new Label();
            lv1 = new ListView();
            lv2 = new ListView();
            lb4 = new Label();
            lb5 = new Label();
            bt3 = new Button();
            ID = new ColumnHeader();
            Name = new ColumnHeader();
            pn1.SuspendLayout();
            SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = SystemColors.Control;
            pn1.BorderStyle = BorderStyle.FixedSingle;
            pn1.Controls.Add(bt2);
            pn1.Controls.Add(lbx1);
            pn1.Controls.Add(tb2);
            pn1.Controls.Add(lb3);
            pn1.Controls.Add(dtp1);
            pn1.Controls.Add(lb2);
            pn1.Location = new Point(258, 74);
            pn1.Name = "pn1";
            pn1.Size = new Size(423, 298);
            pn1.TabIndex = 5;
            pn1.Visible = false;
            // 
            // bt2
            // 
            bt2.BackColor = SystemColors.ActiveCaption;
            bt2.FlatAppearance.BorderColor = Color.Silver;
            bt2.FlatAppearance.BorderSize = 5;
            bt2.FlatStyle = FlatStyle.Popup;
            bt2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt2.Location = new Point(281, 251);
            bt2.Name = "bt2";
            bt2.Size = new Size(68, 30);
            bt2.TabIndex = 24;
            bt2.Text = "Add";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += Bt2_Click;
            // 
            // lbx1
            // 
            lbx1.BackColor = Color.WhiteSmoke;
            lbx1.FormattingEnabled = true;
            lbx1.ItemHeight = 15;
            lbx1.Location = new Point(57, 121);
            lbx1.Name = "lbx1";
            lbx1.Size = new Size(292, 124);
            lbx1.TabIndex = 24;
            lbx1.Visible = false;
            lbx1.DoubleClick += Lbx1_DoubleClick;
            // 
            // tb2
            // 
            tb2.BackColor = Color.White;
            tb2.BorderStyle = BorderStyle.FixedSingle;
            tb2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb2.Location = new Point(56, 97);
            tb2.Name = "tb2";
            tb2.Size = new Size(292, 23);
            tb2.TabIndex = 23;
            tb2.KeyUp += Tb2KeyUp;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb3.Location = new Point(134, 64);
            lb3.Name = "lb3";
            lb3.Size = new Size(132, 30);
            lb3.TabIndex = 20;
            lb3.Text = "Book Name";
            // 
            // dtp1
            // 
            dtp1.Location = new Point(257, 12);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(136, 23);
            dtp1.TabIndex = 21;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb2.Location = new Point(160, 12);
            lb2.Name = "lb2";
            lb2.Size = new Size(91, 23);
            lb2.TabIndex = 20;
            lb2.Text = "Issue Date";
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(613, 8);
            bt1.Name = "bt1";
            bt1.Size = new Size(68, 30);
            bt1.TabIndex = 19;
            bt1.Text = "SEARCH";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb1.Location = new Point(415, 9);
            tb1.Name = "tb1";
            tb1.Size = new Size(192, 29);
            tb1.TabIndex = 18;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb1.Location = new Point(195, 9);
            lb1.Name = "lb1";
            lb1.Size = new Size(214, 30);
            lb1.TabIndex = 17;
            lb1.Text = "Enter Enrollment No";
            // 
            // lv1
            // 
            lv1.BackColor = SystemColors.Control;
            lv1.Location = new Point(12, 74);
            lv1.Name = "lv1";
            lv1.Size = new Size(240, 105);
            lv1.TabIndex = 20;
            lv1.UseCompatibleStateImageBehavior = false;
            lv1.Visible = false;
            // 
            // lv2
            // 
            lv2.BackColor = SystemColors.Control;
            lv2.Columns.AddRange(new ColumnHeader[] { ID, Name });
            lv2.Location = new Point(12, 208);
            lv2.Name = "lv2";
            lv2.Size = new Size(240, 105);
            lv2.TabIndex = 21;
            lv2.UseCompatibleStateImageBehavior = false;
            lv2.Visible = false;
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb4.Location = new Point(12, 48);
            lb4.Name = "lb4";
            lb4.Size = new Size(88, 23);
            lb4.TabIndex = 22;
            lb4.Text = "Barrowed";
            lb4.Visible = false;
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb5.Location = new Point(12, 182);
            lb5.Name = "lb5";
            lb5.Size = new Size(54, 23);
            lb5.TabIndex = 23;
            lb5.Text = "Chart";
            lb5.Visible = false;
            // 
            // bt3
            // 
            bt3.BackColor = SystemColors.ActiveCaption;
            bt3.FlatAppearance.BorderColor = Color.Silver;
            bt3.FlatAppearance.BorderSize = 5;
            bt3.FlatStyle = FlatStyle.Popup;
            bt3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt3.Location = new Point(166, 323);
            bt3.Name = "bt3";
            bt3.Size = new Size(86, 49);
            bt3.TabIndex = 25;
            bt3.Text = "Add";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += Bt3_Click;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 379);
            Controls.Add(bt3);
            Controls.Add(lb5);
            Controls.Add(lb4);
            Controls.Add(lv2);
            Controls.Add(lv1);
            Controls.Add(bt1);
            Controls.Add(tb1);
            Controls.Add(lb1);
            Controls.Add(pn1);
            Text = "Issue Book";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn1;
        private DateTimePicker dtp1;
        private Label lb2;
        private Label lb3;
        private Button bt1;
        private TextBox tb1;
        private Label lb1;
        private TextBox tb2;
        private ListBox lbx1;
        private ListView lv1;
        private ListView lv2;
        private Label lb4;
        private Label lb5;
        private Button bt2;
        private Button bt3;
        private ColumnHeader ID;
        private ColumnHeader Name;
    }
}