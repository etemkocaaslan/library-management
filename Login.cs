using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Login : Form
    {
        int count = 0;
        public Login()
        {
            InitializeComponent();


        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Model.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
            string query = "select * from library_person where username='" + tb1.Text + "' and password='" + tb2.Text + "'";
            count = Convert.ToInt32(Model.ExecuteQuery(query).Rows.Count.ToString());
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