namespace LibraryManagement
{
    partial class BookStockForm
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
            booksGridView = new DataGridView();
            issuesGridView = new DataGridView();
            bt1 = new Button();
            bookNameTextBox = new TextBox();
            lb1 = new Label();
            pn1 = new Panel();
            bt2 = new Button();
            tb3 = new TextBox();
            issueDetailsTextBox = new TextBox();
            lb3 = new Label();
            lb2 = new Label();
            ((System.ComponentModel.ISupportInitialize)booksGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)issuesGridView).BeginInit();
            pn1.SuspendLayout();
            SuspendLayout();
            // 
            // Dgw1
            // 
            booksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksGridView.Location = new Point(238, 11);
            booksGridView.Name = "Dgw1";
            booksGridView.RowTemplate.Height = 25;
            booksGridView.Size = new Size(592, 184);
            booksGridView.TabIndex = 0;
            booksGridView.CellClick += booksGridView_CellClick;
            // 
            // Dgw2
            // 
            issuesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issuesGridView.Location = new Point(238, 205);
            issuesGridView.Name = "Dgw2";
            issuesGridView.RowTemplate.Height = 25;
            issuesGridView.Size = new Size(592, 184);
            issuesGridView.TabIndex = 1;
            issuesGridView.CellClick += issuesGridView_CellClick;
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
            bt1.Click += SearchButton_Click;
            // 
            // tb1
            // 
            bookNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookNameTextBox.Location = new Point(8, 63);
            bookNameTextBox.Name = "tb1";
            bookNameTextBox.Size = new Size(214, 29);
            bookNameTextBox.TabIndex = 21;
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
            pn1.Controls.Add(issueDetailsTextBox);
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
            issueDetailsTextBox.BackColor = Color.Gainsboro;
            issueDetailsTextBox.Location = new Point(61, 19);
            issueDetailsTextBox.Name = "tb2";
            issueDetailsTextBox.Size = new Size(139, 23);
            issueDetailsTextBox.TabIndex = 2;
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
            Controls.Add(bookNameTextBox);
            Controls.Add(lb1);
            Controls.Add(issuesGridView);
            Controls.Add(booksGridView);
            Name = "BookStock";
            Text = "BookStock";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)booksGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)issuesGridView).EndInit();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView booksGridView;
        private DataGridView issuesGridView;
        private Button bt1;
        private TextBox bookNameTextBox;
        private Label lb1;
        private Panel pn1;
        private TextBox tb3;
        private TextBox issueDetailsTextBox;
        private Label lb3;
        private Label lb2;
        private Button bt2;
    }
}