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
                dgw1.DataSource = Model.ExecuteQuery("select * from  books_info where name like('%" + tb1.Text + "%')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pn2.Visible = false;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            try
            {
                dgw1.DataSource = Model.ExecuteQuery("select * from  books_info where author like('%" + tb2.Text + "%')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            pn2.Visible = true;

            var selectedId = dgw1.Rows[e.RowIndex].Cells[0].Value;
            string sql = "SELECT * FROM books_info WHERE Id = @id";
            var parameters = new[] { new SqlParameter("@id", selectedId) };

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
                Model.ExecuteNonQuery("update books_info set name='" + tb3.Text + "',author='" + tb4.Text + "',publisher='" + tb5.Text + "',purchase_date='" + dtp1.Text + "',price='" + tb6.Text + "',quantity='" + tb7.Text + "'where id='" + dgw1.SelectedCells[0].Value + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Bt1_Click(sender, e);

        }
    }
}
