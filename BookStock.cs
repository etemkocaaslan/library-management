using System.Data;
using System.Data.SqlClient;
namespace LibraryManagement
{
    public partial class BookStock : Form
    {
        public BookStock()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void BookStock_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new();
            try
            {
                string query = "SELECT * FROM books_info WHERE id > @id";
                dataTable = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@id", 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Dgw1.DataSource = dataTable;
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Dgw2.DataSource = null;
            try
            {
                string query = "SELECT * FROM books_info WHERE name LIKE @name";
                Dgw1.DataSource = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@name", "%" + tb1.Text + "%"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            object selectedId = Dgw1.Rows[e.RowIndex].Cells[0].Value;
            string sql = "SELECT * FROM issue_books WHERE book_id = @id";
            SqlParameter[] parameters = new[] { new SqlParameter("@id", selectedId) };

            try
            {
                Dgw2.DataSource = DatabaseHelper.ExecuteQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Dgw2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object selectedId = Dgw2.Rows[e.RowIndex].Cells[2].Value;
            tb2.Text = selectedId.ToString();
        }
    }
}
