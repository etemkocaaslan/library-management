namespace WinFormsApp2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pn1 = new Panel();
            lb3 = new Label();
            bt1 = new Button();
            lb2 = new Label();
            tb2 = new TextBox();
            textBox2 = new TextBox();
            lb1 = new Label();
            tb1 = new TextBox();
            pb1 = new PictureBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 489);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(pn1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // pn1
            // 
            pn1.BackColor = Color.White;
            pn1.Controls.Add(lb3);
            pn1.Controls.Add(bt1);
            pn1.Controls.Add(lb2);
            pn1.Controls.Add(tb2);
            pn1.Controls.Add(textBox2);
            pn1.Controls.Add(lb1);
            pn1.Controls.Add(tb1);
            pn1.Controls.Add(pb1);
            pn1.Location = new Point(-4, 0);
            pn1.Name = "pn1";
            pn1.Size = new Size(772, 461);
            pn1.TabIndex = 1;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.Location = new Point(320, 6);
            lb3.Name = "lb3";
            lb3.Size = new Size(113, 50);
            lb3.TabIndex = 11;
            lb3.Text = "Login";
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(465, 289);
            bt1.Name = "bt1";
            bt1.Size = new Size(154, 61);
            bt1.TabIndex = 10;
            bt1.Text = "LOGIN";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.Location = new Point(376, 214);
            lb2.Name = "lb2";
            lb2.Size = new Size(177, 50);
            lb2.TabIndex = 9;
            lb2.Text = "Password";
            // 
            // tb2
            // 
            tb2.BackColor = SystemColors.InactiveCaption;
            tb2.Location = new Point(568, 229);
            tb2.Name = "tb2";
            tb2.PasswordChar = '*';
            tb2.Size = new Size(125, 23);
            tb2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(568, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 8;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(376, 164);
            lb1.Name = "lb1";
            lb1.Size = new Size(186, 50);
            lb1.TabIndex = 7;
            lb1.Text = "Username";
            // 
            // tb1
            // 
            tb1.BackColor = SystemColors.InactiveCaption;
            tb1.Location = new Point(568, 180);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 23);
            tb1.TabIndex = 1;
            // 
            // pb1
            // 
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(57, 84);
            pb1.Name = "pb1";
            pb1.Size = new Size(313, 292);
            pb1.TabIndex = 0;
            pb1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 461);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 489);
            Controls.Add(tabControl1);
            Name = "Login";
            Text = "Login";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel pn1;
        private Button bt1;
        private Label lb2;
        private TextBox tb2;
        private TextBox textBox2;
        private Label lb1;
        private TextBox tb1;
        private PictureBox pb1;
        private TabPage tabPage2;
        private Label lb3;
    }
}