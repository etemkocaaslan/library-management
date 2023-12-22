using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
            Model.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM books_info WHERE name LIKE @name";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", "%" + tb1.Text + "%")
                };

                dgw1.DataSource = Model.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM books_info WHERE author LIKE @author";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@author", "%" + tb2.Text + "%") 
                };
                dgw1.DataSource = Model.ExecuteQuery(query, parameters);
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

            pn2.Visible = true;

            object selectedId = dgw1.Rows[e.RowIndex].Cells[0].Value;
            string sql = "SELECT * FROM books_info WHERE Id = @id";
            SqlParameter[] parameters = new[] { new SqlParameter("@id", selectedId) };

            try
            {
                DataTable table = Model.ExecuteQuery(sql, parameters);
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
        }

        private void PopulateFields(DataRow row)
        {
            tb3.Text = row["name"]?.ToString()?.TrimEnd();
            tb4.Text = row["author"]?.ToString()?.TrimEnd();
            tb5.Text = row["publisher"]?.ToString()?.TrimEnd();
            dtp1.Value = Convert.ToDateTime(row["purchase_date"]);
            tb6.Text = row["price"]?.ToString()?.TrimEnd();
            tb7.Text = row["quantity"]?.ToString()?.TrimEnd();
        }


        private void Bt3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE books_info SET name = @name, author = @author, publisher = @publisher, purchase_date = @purchaseDate, price = @price, quantity = @quantity WHERE id = @id";

                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", tb3.Text),
                    new SqlParameter("@author", tb4.Text),
                    new SqlParameter("@publisher", tb5.Text),
                    new SqlParameter("@purchaseDate", dtp1.Value),
                    new SqlParameter("@price", tb6.Text),
                    new SqlParameter("@quantity", tb7.Text),
                    new SqlParameter("@id", dgw1.SelectedCells[0].Value)
                };

                Model.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pn2.Visible = false;
        }
    }
}
