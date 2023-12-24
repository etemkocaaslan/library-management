namespace WinFormsApp2
{
    public partial class MDIuser : Form
    {
        private int childFormNumber = 0;

        public MDIuser()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new()
            {
                MdiParent = this,
                Text = "Window " + childFormNumber++
            };
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AddNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBooks = new();
            addBooks.Show();
        }

        private void ViewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new();
            viewBooks.Show();
        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new();
            addStudent.Show();
        }

        private void ViewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new();
            viewStudent.Show();
        }

        private void NewIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();
            issueBook.Show();
        }
    }
}
