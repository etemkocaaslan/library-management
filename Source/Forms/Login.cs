using System.Data.SqlClient;
using System.Data;
using LibraryManagement.Source.Helpers;

namespace LibraryManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private async void Bt1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from library_person WHERE username = @username and password = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", tb1.Text),
                new SqlParameter("Password", tb2.Text)
            };
            DataTable dataTable = await Task.Run(() => DatabaseHelper.ExecuteQuery(query, parameters));

            if (dataTable.Rows.Count > 0)
            {
                this.Hide();
                MDIuser mu = new();
                mu.Show();
            }
            else
            {
                MessageBox.Show("username password does not match");
            }
        }
    }
}