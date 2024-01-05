namespace WinFormsApp2
{
    partial class MDIuser
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
            menuStrip = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            newIssueToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            viewStockToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentsToolStripMenuItem, stockToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(471, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, viewBooksToolStripMenuItem, newIssueToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(51, 20);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(129, 22);
            addNewBooksToolStripMenuItem.Text = "New Book";
            addNewBooksToolStripMenuItem.Click += AddNewBooksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(129, 22);
            viewBooksToolStripMenuItem.Text = "View Book";
            viewBooksToolStripMenuItem.Click += ViewBooksToolStripMenuItem_Click;
            // 
            // newIssueToolStripMenuItem
            // 
            newIssueToolStripMenuItem.Name = "newIssueToolStripMenuItem";
            newIssueToolStripMenuItem.Size = new Size(129, 22);
            newIssueToolStripMenuItem.Text = "New Issue";
            newIssueToolStripMenuItem.Click += NewIssueToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(164, 22);
            addStudentToolStripMenuItem.Text = "Add new student";
            addStudentToolStripMenuItem.Click += AddStudentToolStripMenuItem_Click;
            // 
            // viewStudentToolStripMenuItem
            // 
            viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            viewStudentToolStripMenuItem.Size = new Size(164, 22);
            viewStudentToolStripMenuItem.Text = "View students";
            viewStudentToolStripMenuItem.Click += ViewStudentToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStockToolStripMenuItem });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(48, 20);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // viewStockToolStripMenuItem
            // 
            viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            viewStockToolStripMenuItem.Size = new Size(130, 22);
            viewStockToolStripMenuItem.Text = "View stock";
            viewStockToolStripMenuItem.Click += ViewStockToolStripMenuItem_Click;
            // 
            // MDIuser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 481);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIuser";
            Text = "mdi_user";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private ToolTip toolTip;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentToolStripMenuItem;
        private ToolStripMenuItem newIssueToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem viewStockToolStripMenuItem;
    }
}



