namespace LibraryManagement
{
    partial class AddStudentForm
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
            emailTextBox = new TextBox();
            contactTextBox = new TextBox();
            departmentTextBox = new TextBox();
            enrollmentNoTextBox = new TextBox();
            nameTextBox = new TextBox();
            bt1 = new Button();
            lb6 = new Label();
            lb5 = new Label();
            lb4 = new Label();
            lb3 = new Label();
            lb2 = new Label();
            lb1 = new Label();
            pn1 = new Panel();
            semTextBox = new TextBox();
            studentPictureBox = new PictureBox();
            bt2 = new Button();
            bt3 = new Button();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tb6
            // 
            emailTextBox.BackColor = SystemColors.Window;
            emailTextBox.Location = new Point(309, 220);
            emailTextBox.Name = "tb6";
            emailTextBox.Size = new Size(136, 23);
            emailTextBox.TabIndex = 31;
            // 
            // tb5
            // 
            contactTextBox.BackColor = SystemColors.Window;
            contactTextBox.Location = new Point(58, 220);
            contactTextBox.Name = "tb5";
            contactTextBox.Size = new Size(133, 23);
            contactTextBox.TabIndex = 30;
            // 
            // tb3
            // 
            departmentTextBox.BackColor = SystemColors.Window;
            departmentTextBox.Location = new Point(58, 146);
            departmentTextBox.Name = "tb3";
            departmentTextBox.Size = new Size(133, 23);
            departmentTextBox.TabIndex = 29;
            // 
            // tb2
            // 
            enrollmentNoTextBox.BackColor = SystemColors.Window;
            enrollmentNoTextBox.Location = new Point(309, 67);
            enrollmentNoTextBox.Name = "tb2";
            enrollmentNoTextBox.Size = new Size(136, 23);
            enrollmentNoTextBox.TabIndex = 28;
            // 
            // tb1
            // 
            nameTextBox.BackColor = SystemColors.Window;
            nameTextBox.Location = new Point(58, 67);
            nameTextBox.Name = "tb1";
            nameTextBox.Size = new Size(133, 23);
            nameTextBox.TabIndex = 27;
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
            bt1.Click += AddStudentButton_Click;
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
            pn1.Controls.Add(semTextBox);
            pn1.Controls.Add(lb1);
            pn1.Controls.Add(lb2);
            pn1.Controls.Add(emailTextBox);
            pn1.Controls.Add(lb3);
            pn1.Controls.Add(contactTextBox);
            pn1.Controls.Add(lb4);
            pn1.Controls.Add(departmentTextBox);
            pn1.Controls.Add(lb5);
            pn1.Controls.Add(enrollmentNoTextBox);
            pn1.Controls.Add(lb6);
            pn1.Controls.Add(nameTextBox);
            pn1.Controls.Add(bt1);
            pn1.Location = new Point(12, 217);
            pn1.Name = "pn1";
            pn1.Size = new Size(521, 352);
            pn1.TabIndex = 33;
            // 
            // tb4
            // 
            semTextBox.BackColor = SystemColors.Window;
            semTextBox.Location = new Point(309, 146);
            semTextBox.Name = "tb4";
            semTextBox.ShortcutsEnabled = false;
            semTextBox.Size = new Size(136, 23);
            semTextBox.TabIndex = 32;
            // 
            // pb1
            // 
            studentPictureBox.Location = new Point(180, 12);
            studentPictureBox.Name = "pb1";
            studentPictureBox.Size = new Size(178, 170);
            studentPictureBox.TabIndex = 34;
            studentPictureBox.TabStop = false;
            // 
            // bt2
            // 
            bt2.Location = new Point(180, 188);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 23);
            bt2.TabIndex = 36;
            bt2.Text = "Upload";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += LoadImageButton_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(283, 188);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 23);
            bt3.TabIndex = 37;
            bt3.Text = "Clear";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += ClearImageButton_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 579);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(studentPictureBox);
            Controls.Add(pn1);
            Name = "AddStudent";
            Text = "AddStudent";
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox emailTextBox;
        private TextBox contactTextBox;
        private TextBox departmentTextBox;
        private TextBox enrollmentNoTextBox;
        private TextBox nameTextBox;
        private Button bt1;
        private Label lb6;
        private Label lb5;
        private Label lb4;
        private Label lb3;
        private Label lb2;
        private Label lb1;
        private Panel pn1;
        private PictureBox studentPictureBox;
        private TextBox semTextBox;
        private Button bt2;
        private Button bt3;
    }
}