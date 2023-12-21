using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Model.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private async void Bt1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from library_person WHERE username = @username and password = @password";
            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@username", tb1.Text),
                new SqlParameter("Password", tb2.Text)
            };
            DataTable dataTable = await Task.Run(() => Model.ExecuteQuery(query, parameters));

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