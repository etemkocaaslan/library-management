namespace WinFormsApp2
{
    partial class AddBooks
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
            lb1 = new Label();
            lb2 = new Label();
            lb4 = new Label();
            lb3 = new Label();
            lb6 = new Label();
            lb5 = new Label();
            bt1 = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            tb3 = new TextBox();
            tb5 = new TextBox();
            tb6 = new TextBox();
            dtp1 = new DateTimePicker();
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
            bt1.Click += Bt1_Click;
            // 
            // tb1
            // 
            tb1.BackColor = SystemColors.Window;
            tb1.Location = new Point(33, 62);
            tb1.Name = "tb1";
            tb1.Size = new Size(133, 23);
            tb1.TabIndex = 13;
            // 
            // tb2
            // 
            tb2.BackColor = SystemColors.Window;
            tb2.Location = new Point(280, 62);
            tb2.Name = "tb2";
            tb2.Size = new Size(136, 23);
            tb2.TabIndex = 14;
            // 
            // tb3
            // 
            tb3.BackColor = SystemColors.Window;
            tb3.Location = new Point(33, 141);
            tb3.Name = "tb3";
            tb3.Size = new Size(133, 23);
            tb3.TabIndex = 15;
            // 
            // tb5
            // 
            tb5.BackColor = SystemColors.Window;
            tb5.Location = new Point(33, 215);
            tb5.Name = "tb5";
            tb5.Size = new Size(133, 23);
            tb5.TabIndex = 16;
            // 
            // tb6
            // 
            tb6.BackColor = SystemColors.Window;
            tb6.Location = new Point(280, 215);
            tb6.Name = "tb6";
            tb6.Size = new Size(136, 23);
            tb6.TabIndex = 18;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(280, 141);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(136, 23);
            dtp1.TabIndex = 19;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(427, 346);
            Controls.Add(dtp1);
            Controls.Add(tb6);
            Controls.Add(tb5);
            Controls.Add(tb3);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(bt1);
            Controls.Add(lb6);
            Controls.Add(lb5);
            Controls.Add(lb4);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Name = "AddBooks";
            Text = "Add Books";
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
        private TextBox tb1;
        private TextBox tb2;
        private TextBox tb3;
        private TextBox tb5;
        private TextBox tb6;
        private DateTimePicker dtp1;
    }
}