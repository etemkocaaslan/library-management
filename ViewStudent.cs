using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp2
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Student WHERE name LIKE @name";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", "%" + tb1.Text + "%")
                };

                dgw1.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);
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
                string query = "SELECT * FROM student WHERE id LIKE @id";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@id", "%" + tb2.Text + "%")
                };
                dgw1.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pn2.Visible = false;
        }
        private void Dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            pn2.Visible = true;

            object selectedId = dgw1.Rows[e.RowIndex].Cells[0].Value;
            string query = "SELECT * FROM Student WHERE Id = @id";
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@id", selectedId)
            };

            try
            {
                PopulateFields(DatabaseHelper.ExecuteQuery(query, parameters));
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void PopulateFields(DataTable table)
        {
            tb3.Text = table.Rows[0]["name"].ToString()?.TrimEnd();
            tb4.Text = table.Rows[0]["enrollment_no"].ToString()?.TrimEnd();
            tb5.Text = table.Rows[0]["department"].ToString()?.TrimEnd();
            tb6.Text = table.Rows[0]["sem"].ToString()?.TrimEnd();
            tb7.Text = table.Rows[0]["contact"].ToString()?.TrimEnd();
            tb8.Text = table.Rows[0]["email"].ToString()?.TrimEnd();
            pb1.Image = Image.FromStream(new MemoryStream((Byte[])table.Rows[0]["image"]));

        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE student SET name = @name, enrollment_no = @enrollment_no, department = @department, sem = @sem, contact = @contact, email = @email WHERE id = @id";

                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", tb3.Text),
                    new SqlParameter("@enrollment_no", tb4.Text),
                    new SqlParameter("@department", tb5.Text),
                    new SqlParameter("@sem", tb6.Text),
                    new SqlParameter("@contact", tb7.Text),
                    new SqlParameter("@email", tb8.Text),
                    new SqlParameter("id", dgw1.SelectedCells[0].Value)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pn2.Visible = false;
        }
    }
}
