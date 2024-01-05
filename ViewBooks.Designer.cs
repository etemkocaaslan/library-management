namespace LibraryManagement
{
    partial class ViewBooks
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
            dgw1 = new DataGridView();
            lb3 = new Label();
            lb6 = new Label();
            lb4 = new Label();
            lb7 = new Label();
            lb5 = new Label();
            lb8 = new Label();
            tb3 = new TextBox();
            tb5 = new TextBox();
            tb4 = new TextBox();
            tb7 = new TextBox();
            tb6 = new TextBox();
            dtp1 = new DateTimePicker();
            bt3 = new Button();
            pn2 = new Panel();
            lb1 = new Label();
            tb1 = new TextBox();
            lb2 = new Label();
            bt1 = new Button();
            tb2 = new TextBox();
            bt2 = new Button();
            pn1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgw1).BeginInit();
            pn2.SuspendLayout();
            pn1.SuspendLayout();
            SuspendLayout();
            // 
            // dgw1
            // 
            dgw1.BackgroundColor = SystemColors.ControlLight;
            dgw1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw1.Location = new Point(263, 12);
            dgw1.Name = "dgw1";
            dgw1.RowTemplate.Height = 25;
            dgw1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw1.Size = new Size(666, 393);
            dgw1.TabIndex = 0;
            dgw1.CellClick += Dgw1_CellClick;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.Location = new Point(58, 35);
            lb3.Name = "lb3";
            lb3.Size = new Size(69, 30);
            lb3.TabIndex = 20;
            lb3.Text = "Name";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb6.Location = new Point(381, 35);
            lb6.Name = "lb6";
            lb6.Size = new Size(57, 30);
            lb6.TabIndex = 21;
            lb6.Text = "Date";
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb4.Location = new Point(50, 76);
            lb4.Name = "lb4";
            lb4.Size = new Size(77, 30);
            lb4.TabIndex = 22;
            lb4.Text = "Author";
            // 
            // lb7
            // 
            lb7.AutoSize = true;
            lb7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb7.Location = new Point(381, 76);
            lb7.Name = "lb7";
            lb7.Size = new Size(58, 30);
            lb7.TabIndex = 23;
            lb7.Text = "Price";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb5.Location = new Point(29, 117);
            lb5.Name = "lb5";
            lb5.Size = new Size(98, 30);
            lb5.TabIndex = 24;
            lb5.Text = "Publisher";
            // 
            // lb8
            // 
            lb8.AutoSize = true;
            lb8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb8.Location = new Point(346, 117);
            lb8.Name = "lb8";
            lb8.Size = new Size(93, 30);
            lb8.TabIndex = 25;
            lb8.Text = "Quantity";
            // 
            // tb3
            // 
            tb3.BackColor = SystemColors.Window;
            tb3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb3.Location = new Point(133, 35);
            tb3.Name = "tb3";
            tb3.Size = new Size(205, 35);
            tb3.TabIndex = 28;
            // 
            // tb5
            // 
            tb5.BackColor = SystemColors.Window;
            tb5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb5.Location = new Point(133, 117);
            tb5.Name = "tb5";
            tb5.Size = new Size(205, 35);
            tb5.TabIndex = 29;
            // 
            // tb4
            // 
            tb4.BackColor = SystemColors.Window;
            tb4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb4.Location = new Point(133, 76);
            tb4.Name = "tb4";
            tb4.Size = new Size(205, 35);
            tb4.TabIndex = 26;
            // 
            // tb7
            // 
            tb7.BackColor = SystemColors.Window;
            tb7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb7.Location = new Point(444, 117);
            tb7.Name = "tb7";
            tb7.Size = new Size(205, 35);
            tb7.TabIndex = 27;
            // 
            // tb6
            // 
            tb6.BackColor = SystemColors.Window;
            tb6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb6.Location = new Point(445, 76);
            tb6.Name = "tb6";
            tb6.Size = new Size(205, 35);
            tb6.TabIndex = 30;
            // 
            // dtp1
            // 
            dtp1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp1.Location = new Point(444, 35);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(205, 35);
            dtp1.TabIndex = 31;
            // 
            // bt3
            // 
            bt3.BackColor = SystemColors.ActiveCaption;
            bt3.FlatAppearance.BorderColor = Color.Silver;
            bt3.FlatAppearance.BorderSize = 5;
            bt3.FlatStyle = FlatStyle.Popup;
            bt3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt3.Location = new Point(275, 168);
            bt3.Name = "bt3";
            bt3.Size = new Size(108, 45);
            bt3.TabIndex = 32;
            bt3.Text = "UPDATE";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += Bt3_Click;
            // 
            // pn2
            // 
            pn2.BackColor = SystemColors.ControlLight;
            pn2.Controls.Add(bt3);
            pn2.Controls.Add(dtp1);
            pn2.Controls.Add(tb6);
            pn2.Controls.Add(tb7);
            pn2.Controls.Add(tb4);
            pn2.Controls.Add(tb5);
            pn2.Controls.Add(tb3);
            pn2.Controls.Add(lb8);
            pn2.Controls.Add(lb5);
            pn2.Controls.Add(lb7);
            pn2.Controls.Add(lb4);
            pn2.Controls.Add(lb6);
            pn2.Controls.Add(lb3);
            pn2.Location = new Point(263, 411);
            pn2.Name = "pn2";
            pn2.Size = new Size(666, 227);
            pn2.TabIndex = 2;
            pn2.Visible = false;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(19, 59);
            lb1.Name = "lb1";
            lb1.Size = new Size(69, 30);
            lb1.TabIndex = 0;
            lb1.Text = "Name";
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb1.Location = new Point(92, 59);
            tb1.Name = "tb1";
            tb1.Size = new Size(128, 29);
            tb1.TabIndex = 1;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.Location = new Point(11, 160);
            lb2.Name = "lb2";
            lb2.Size = new Size(77, 30);
            lb2.TabIndex = 14;
            lb2.Text = "Author";
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(92, 94);
            bt1.Name = "bt1";
            bt1.Size = new Size(109, 45);
            bt1.TabIndex = 13;
            bt1.Text = "SEARCH";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // tb2
            // 
            tb2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb2.Location = new Point(92, 161);
            tb2.Name = "tb2";
            tb2.Size = new Size(128, 29);
            tb2.TabIndex = 15;
            // 
            // bt2
            // 
            bt2.BackColor = SystemColors.ActiveCaption;
            bt2.FlatAppearance.BorderColor = Color.Silver;
            bt2.FlatAppearance.BorderSize = 5;
            bt2.FlatStyle = FlatStyle.Popup;
            bt2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt2.Location = new Point(92, 196);
            bt2.Name = "bt2";
            bt2.Size = new Size(109, 45);
            bt2.TabIndex = 16;
            bt2.Text = "SEARCH";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += Bt2_Click;
            // 
            // pn1
            // 
            pn1.BackColor = SystemColors.ControlLight;
            pn1.Controls.Add(bt2);
            pn1.Controls.Add(tb2);
            pn1.Controls.Add(bt1);
            pn1.Controls.Add(lb2);
            pn1.Controls.Add(tb1);
            pn1.Controls.Add(lb1);
            pn1.Location = new Point(12, 12);
            pn1.Name = "pn1";
            pn1.Size = new Size(245, 393);
            pn1.TabIndex = 1;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 646);
            Controls.Add(pn2);
            Controls.Add(pn1);
            Controls.Add(dgw1);
            Name = "ViewBooks";
            Text = "ViewBooks";
            ((System.ComponentModel.ISupportInitialize)dgw1).EndInit();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgw1;
        private Label lb3;
        private Label lb6;
        private Label lb4;
        private Label lb7;
        private Label lb5;
        private Label lb8;
        private TextBox tb3;
        private TextBox tb5;
        private TextBox tb4;
        private TextBox tb7;
        private TextBox tb6;
        private DateTimePicker dtp1;
        private Button bt3;
        private Panel pn2;
        private Label lb1;
        private TextBox tb1;
        private Label lb2;
        private Button bt1;
        private TextBox tb2;
        private Button bt2;
        private Panel pn1;
    }
}