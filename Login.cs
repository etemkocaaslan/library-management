using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        int count = 0;
        public Login()
        {
            InitializeComponent();

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from library_person where username='" + tb1.Text + "' and password='" + tb2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            count = dt.Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("username password does not match");
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }
        }
    }
}