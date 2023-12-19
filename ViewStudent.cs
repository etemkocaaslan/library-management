using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp2
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            Model.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                dgw1.DataSource = Model.ExecuteQuery("SELECT * FROM  Student WHERE name like('%" + tb1.Text + "%')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pn2.Visible = false;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            try
            {
                dgw1.DataSource = Model.ExecuteQuery("SELECT * FROM  Student WHERE name like('%" + tb2.Text + "%')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pn2.Visible = false;
        }
        private void Dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            pn2.Visible = true;

            var selectedId = dgw1.Rows[e.RowIndex].Cells[0].Value;
            string sql = "SELECT * FROM Student WHERE Id = @id";
            var parameters = new[] { new SqlParameter("@id", selectedId) };

            try
            {
                PopulateFields(Model.ExecuteQuery(sql, parameters));
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
        // old approach
        //private void PopulateFields(DataRow row)
        //{
        //    tb3.Text = row["name"]?.ToString()?.TrimEnd();
        //    tb4.Text = row["enrollment_no"]?.ToString()?.TrimEnd();
        //    tb5.Text = row["department"]?.ToString()?.TrimEnd();
        //    tb6.Text = row["sem"]?.ToString()?.TrimEnd();
        //    tb7.Text = row["contact"]?.ToString()?.TrimEnd();
        //    tb8.Text = row["email"]?.ToString()?.TrimEnd();
        //}

        private void dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
