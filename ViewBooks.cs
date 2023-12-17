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
        }
    }
}
