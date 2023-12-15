using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
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
