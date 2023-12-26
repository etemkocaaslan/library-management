using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM issue_books WHERE student_enrollment_no = @student_enrollment_no";

                dgw1.DataSource = DatabaseHelper.ExecuteQuery(query, new SqlParameter("student_enrollment_no", tb1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            object selectedId = dgw1.Rows[e.RowIndex].Cells[2].Value;
            string query = "SELECT * FROM issue_books WHERE student_enrollment_no = @student_enrollment_no";

            try
            {
                DataTable table = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@student_enrollment_no", selectedId));
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    PopulateFields(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            pn2.Visible = true;
        }

        private void PopulateFields(DataRow row)
        {
            lb7.Text = row["book_name"]?.ToString()?.TrimEnd();
            lb8.Text = row["book_id"]?.ToString()?.TrimEnd();
            lb9.Text = row["issue_date"]?.ToString()?.TrimEnd();
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            UpdateAvailable(lb8.Text);
            pn2.Visible = false;
        }

        private void UpdateAvailable(object id)
        {
            try
            {
                string commandTxt = "UPDATE books_info SET available = available + 1 WHERE ID = @id";
                DatabaseHelper.ExecuteNonQuery(commandTxt, new SqlParameter("@id", id));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
