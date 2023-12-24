using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace WinFormsApp2
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            pb1.Image = FileManager.GetImage();
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new();
                pb1.Image.Save(memoryStream, ImageFormat.Jpeg);

                string sql = "Insert into Student(name, enrollment_no, department, sem, contact, email, image) Values(@name, @enrollment_no, @department, @sem, @contact, @email, @image)";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", tb1.Text),
                    new SqlParameter("@enrollment_no", tb2.Text),
                    new SqlParameter("@department", tb3.Text),
                    new SqlParameter("@sem", tb4.Text),
                    new SqlParameter("@contact", tb5.Text),
                    new SqlParameter("@email", tb6.Text),
                    new SqlParameter("@image", memoryStream.ToArray())
                };

                DatabaseHelper.ExecuteNonQuery(sql, parameters);
                MessageBox.Show("Student is added successfully");

                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
                tb5.Clear();
                tb6.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

    }
}
