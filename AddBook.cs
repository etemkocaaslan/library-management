using System.Data.SqlClient;
using System.IO;

namespace WinFormsApp2
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            try
            {
                string commandTxt = "Insert into books_info(name, author, publisher, purchase_date, price, quantity) Values(@name, @author, @publisher, @purchase_date, @price, @quantity)";
                var parameters = new[]
                {
                    new SqlParameter("@name", tb1.Text),
                    new SqlParameter("@author", tb2.Text),
                    new SqlParameter("@publisher", tb3.Text),
                    new SqlParameter("@purchase_date", dtp1.Text),
                    new SqlParameter("@price", tb5.Text),
                    new SqlParameter("@quantity", tb6.Text),
                };

                Model.ExecuteNonQuery(commandTxt, parameters);
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
