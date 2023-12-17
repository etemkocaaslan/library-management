namespace WinFormsApp2
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
            pn1 = new Panel();
            tb1 = new TextBox();
            lb1 = new Label();
            bt1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw1).BeginInit();
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
            dgw1.Size = new Size(633, 496);
            dgw1.TabIndex = 0;
            // 
            // pn1
            // 
            pn1.BackColor = SystemColors.ControlLight;
            pn1.Controls.Add(bt1);
            pn1.Controls.Add(tb1);
            pn1.Controls.Add(lb1);
            pn1.Location = new Point(12, 12);
            pn1.Name = "pn1";
            pn1.Size = new Size(245, 496);
            pn1.TabIndex = 1;
            // 
            // tb1
            // 
            tb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb1.Location = new Point(102, 55);
            tb1.Name = "tb1";
            tb1.Size = new Size(128, 29);
            tb1.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(27, 51);
            lb1.Name = "lb1";
            lb1.Size = new Size(69, 30);
            lb1.TabIndex = 0;
            lb1.Text = "Name";
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveCaption;
            bt1.FlatAppearance.BorderColor = Color.Silver;
            bt1.FlatAppearance.BorderSize = 5;
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.Location = new Point(57, 107);
            bt1.Name = "bt1";
            bt1.Size = new Size(124, 48);
            bt1.TabIndex = 13;
            bt1.Text = "SAVE";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += Bt1_Click;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 520);
            Controls.Add(pn1);
            Controls.Add(dgw1);
            Name = "ViewBooks";
            Text = "ViewBooks";
            ((System.ComponentModel.ISupportInitialize)dgw1).EndInit();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgw1;
        private Panel pn1;
        private TextBox tb1;
        private Label lb1;
        private Button bt1;
    }
}