using System.Data;
using System.Data.SqlClient;
namespace LibraryManagement
{
    public partial class BookStockForm : Form
    {
        public BookStockForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True";
            DatabaseHelper.InitializeConnection(connectionString);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            PopulateBookGridView();
        }

        private void PopulateBookGridView()
        {
            try
            {
                booksGridView.DataSource = FetchAllBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load books: " + ex.Message);
            }
        }
        private DataTable FetchAllBooks()
        {
            const string query = "SELECT * FROM books_info WHERE id > @id";
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter("@id", 1));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterBooksByName(bookNameTextBox.Text);
        }

        private void FilterBooksByName(string bookName)
        {
            try
            {
                string query = "SELECT * FROM books_info WHERE name LIKE @name";
                booksGridView.DataSource = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@name", "%" + bookName + "%"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to filter books: " + ex.Message);
            }
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsValidGridCell(e))
            {
                DisplayIssuesForBook(e.RowIndex);
            }
        }

        private bool IsValidGridCell(DataGridViewCellEventArgs e)
        {
            return e.RowIndex >= 0 && e.ColumnIndex >= 0;
        }

        private void DisplayIssuesForBook(int rowIndex)
        {
            try
            {
                var bookId = booksGridView.Rows[rowIndex].Cells[0].Value;
                issuesGridView.DataSource = FetchIssuesForBook(bookId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to display book issues: {ex.Message}");
            }
        }
        private DataTable FetchIssuesForBook(object bookId)
        {
            string query = "SELECT * FROM issue_books WHERE book_id = @id";
            SqlParameter[] parameters = new[] { new SqlParameter("@id", bookId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        private void issuesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsValidGridCell(e))
            {
                UpdateIssueDetails(e.RowIndex);
            }
        }
        private void UpdateIssueDetails(int rowIndex)
        {
            // Assumes the ID is in the 3rd cell of the selected row
            var selectedIssueId = issuesGridView.Rows[rowIndex].Cells[2].Value;
            issueDetailsTextBox.Text = selectedIssueId.ToString(); // Renamed tb2 to issueDetailsTextBox for clarity
        }
    }
}
