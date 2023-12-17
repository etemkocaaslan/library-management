namespace WinFormsApp2
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                Model.ExecuteNonQuery("insert  into books_info values('" + tb1.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + dtp1.Text + "'," + tb5.Text + "," + tb6.Text + ")");
                MessageBox.Show("Books are added successfully");

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
