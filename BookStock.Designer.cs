namespace WinFormsApp2
{
    partial class BookStock
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
            Dgw1 = new DataGridView();
            Dgw2 = new DataGridView();
            bt1 = new Button();
            tb1 = new TextBox();
            lb1 = new Label();
            pn1 = new Panel();
            bt2 = new Button();
            tb3 = new TextBox();
            tb2 = new TextBox();
            lb3 = new Label();
            lb2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgw1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgw2).BeginInit();
            pn1.SuspendLayout();
            SuspendLayout();
            // 
            // Dgw1
            // 
            Dgw1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw1.Location = new Point(238, 11);
            Dgw1.Name = "Dgw1";
            Dgw1.RowTemplate.Height = 25;
            Dgw1.Size = new Size(592, 184);
            Dgw1.TabIndex = 0;
            Dgw1.CellClick += Dgw1_CellClick;
            // 
            // Dgw2
            // 
            Dgw2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw2.Location = new Point(238, 205);
            Dgw2.Name = "Dgw2";
            Dgw2.RowTemplate.Height = 25;
            Dgw2.Size = new Size(592, 184);
            Dgw2.TabIndex = 1;
            Dgw2.CellClick += Dgw2_CellClick;
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(81, 98);
            bt1.Name = "bt1";
            bt1.Size = new Size(68, 30);
            bt1.TabIndex = 22;
            bt1.Text = "SEARCH";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb1.Location = new Point(8, 63);
            tb1.Name = "tb1";
            tb1.Size = new Size(214, 29);
            tb1.TabIndex = 21;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb1.Location = new Point(80, 30);
            lb1.Name = "lb1";
            lb1.Size = new Size(71, 30);
            lb1.TabIndex = 20;
            lb1.Text = "Name";
            // 
            // pn1
            // 
            pn1.Controls.Add(bt2);
            pn1.Controls.Add(tb3);
            pn1.Controls.Add(tb2);
            pn1.Controls.Add(lb3);
            pn1.Controls.Add(lb2);
            pn1.Location = new Point(12, 205);
            pn1.Name = "pn1";
            pn1.Size = new Size(210, 182);
            pn1.TabIndex = 23;
            // 
            // bt2
            // 
            bt2.BackColor = SystemColors.ActiveCaption;
            bt2.FlatAppearance.BorderColor = Color.Silver;
            bt2.FlatAppearance.BorderSize = 5;
            bt2.FlatStyle = FlatStyle.Popup;
            bt2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt2.Location = new Point(96, 146);
            bt2.Name = "bt2";
            bt2.Size = new Size(68, 30);
            bt2.TabIndex = 24;
            bt2.Text = "SEND";
            bt2.UseVisualStyleBackColor = false;
            // 
            // tb3
            // 
            tb3.BackColor = Color.Gainsboro;
            tb3.Location = new Point(61, 48);
            tb3.Multiline = true;
            tb3.Name = "tb3";
            tb3.Size = new Size(139, 92);
            tb3.TabIndex = 3;
            // 
            // tb2
            // 
            tb2.BackColor = Color.Gainsboro;
            tb2.Location = new Point(61, 19);
            tb2.Name = "tb2";
            tb2.Size = new Size(139, 23);
            tb2.TabIndex = 2;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(3, 51);
            lb3.Name = "lb3";
            lb3.Size = new Size(50, 15);
            lb3.TabIndex = 1;
            lb3.Text = "Content";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(17, 22);
            lb2.Name = "lb2";
            lb2.Size = new Size(36, 15);
            lb2.TabIndex = 0;
            lb2.Text = "Email";
            // 
            // BookStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 399);
            Controls.Add(pn1);
            Controls.Add(bt1);
            Controls.Add(tb1);
            Controls.Add(lb1);
            Controls.Add(Dgw2);
            Controls.Add(Dgw1);
            Name = "BookStock";
            Text = "BookStock";
            Load += BookStock_Load;
            ((System.ComponentModel.ISupportInitialize)Dgw1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgw2).EndInit();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgw1;
        private DataGridView Dgw2;
        private Button bt1;
        private TextBox tb1;
        private Label lb1;
        private Panel pn1;
        private TextBox tb3;
        private TextBox tb2;
        private Label lb3;
        private Label lb2;
        private Button bt2;
    }
}