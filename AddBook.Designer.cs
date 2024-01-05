namespace WinFormsApp2
{
    partial class AddBookForm
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
            components = new System.ComponentModel.Container();
            lb1 = new Label();
            lb2 = new Label();
            lb4 = new Label();
            lb3 = new Label();
            lb6 = new Label();
            lb5 = new Label();
            bt1 = new Button();
            nameTextBox = new TextBox();
            authorTextBox = new TextBox();
            publisherTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            purchaseDatePicker = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(38, 9);
            lb1.Name = "lb1";
            lb1.Size = new Size(120, 50);
            lb1.TabIndex = 1;
            lb1.Text = "Name";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.Location = new Point(272, 9);
            lb2.Name = "lb2";
            lb2.Size = new Size(136, 50);
            lb2.TabIndex = 3;
            lb2.Text = "Author";
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb4.Location = new Point(291, 88);
            lb4.Name = "lb4";
            lb4.Size = new Size(99, 50);
            lb4.TabIndex = 7;
            lb4.Text = "Date";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.Location = new Point(12, 88);
            lb3.Name = "lb3";
            lb3.Size = new Size(173, 50);
            lb3.TabIndex = 5;
            lb3.Text = "Publisher";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb6.Location = new Point(259, 167);
            lb6.Name = "lb6";
            lb6.Size = new Size(164, 50);
            lb6.TabIndex = 11;
            lb6.Text = "Quantity";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb5.Location = new Point(48, 167);
            lb5.Name = "lb5";
            lb5.Size = new Size(101, 50);
            lb5.TabIndex = 9;
            lb5.Text = "Price";
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(150, 269);
            bt1.Name = "bt1";
            bt1.Size = new Size(154, 61);
            bt1.TabIndex = 12;
            bt1.Text = "SAVE";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += AddBookButton_Click;
            // 
            // tb1
            // 
            nameTextBox.BackColor = SystemColors.Window;
            nameTextBox.Location = new Point(33, 62);
            nameTextBox.Name = "tb1";
            nameTextBox.Size = new Size(133, 23);
            nameTextBox.TabIndex = 13;
            // 
            // tb2
            // 
            authorTextBox.BackColor = SystemColors.Window;
            authorTextBox.Location = new Point(280, 62);
            authorTextBox.Name = "tb2";
            authorTextBox.Size = new Size(136, 23);
            authorTextBox.TabIndex = 14;
            // 
            // tb3
            // 
            publisherTextBox.BackColor = SystemColors.Window;
            publisherTextBox.Location = new Point(33, 141);
            publisherTextBox.Name = "tb3";
            publisherTextBox.Size = new Size(133, 23);
            publisherTextBox.TabIndex = 15;
            // 
            // tb5
            // 
            priceTextBox.BackColor = SystemColors.Window;
            priceTextBox.Location = new Point(33, 215);
            priceTextBox.Name = "tb5";
            priceTextBox.Size = new Size(133, 23);
            priceTextBox.TabIndex = 16;
            // 
            // tb6
            // 
            quantityTextBox.BackColor = SystemColors.Window;
            quantityTextBox.Location = new Point(280, 215);
            quantityTextBox.Name = "tb6";
            quantityTextBox.Size = new Size(136, 23);
            quantityTextBox.TabIndex = 18;
            // 
            // dtp1
            // 
            purchaseDatePicker.Location = new Point(280, 141);
            purchaseDatePicker.Name = "dtp1";
            purchaseDatePicker.Size = new Size(136, 23);
            purchaseDatePicker.TabIndex = 19;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(427, 346);
            Controls.Add(purchaseDatePicker);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(publisherTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(bt1);
            Controls.Add(lb6);
            Controls.Add(lb5);
            Controls.Add(lb4);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Name = "AddBook";
            Text = "Add Books";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb1;
        private Label lb2;
        private Label lb4;
        private Label lb3;
        private Label lb6;
        private Label lb5;
        private Button bt1;
        private TextBox nameTextBox;
        private TextBox authorTextBox;
        private TextBox publisherTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private DateTimePicker purchaseDatePicker;
        private ErrorProvider errorProvider1;
    }
}