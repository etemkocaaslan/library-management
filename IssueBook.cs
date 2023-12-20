using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
            Model.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void BarrowedCheck()
        {
            DataTable issuedbooksDT = new();
            try
            {
                issuedbooksDT = Model.ExecuteQuery("SELECT * FROM issue_books WHERE student_enrollment_no like('%" + tb1.Text + "%')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataRow row in issuedbooksDT.Rows)
            {
                lv1.Items.Add(row["book_id"] + "-" + row["book_name"].ToString());
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lbx1.Visible = true;
            lbx1.Items.Clear();
            DataTable issuedbooksDT;
            try
            {
                issuedbooksDT = Model.ExecuteQuery("SELECT * FROM books_info WHERE name like('%" + tb2.Text + "%')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            foreach (DataRow row in issuedbooksDT.Rows)
            {
                lbx1.Items.Add(row["id"] + "-" + row["name"].ToString());
            }

        }


        private void Bt1_Click(object sender, EventArgs e)
        {
            if (tb1.TextLength > 0)
            {
                try
                {
                    using DataTable dt = (DataTable)Model.ExecuteQuery("SELECT * FROM  STUDENT WHERE enrollment_no like('%" + tb1.Text + "%')");
                    pn1.Visible = true;

                    lv1.Clear();
                    BarrowedCheck();
                    lb4.Visible = true;
                    lb5.Visible = true;
                    lv1.Visible = true;
                    lv2.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                pn1.Visible = false;
                lb4.Visible = false;
                lb5.Visible = false;
                lv1.Visible = false;
                lv2.Visible = false;
            }

        }
        private void Bt2_Click(object sender, EventArgs e)
        {
            lv2.Items.Add(lbx1.SelectedItems.ToString());
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            try
            {
                string commandTxt = "Insert into issue_books(student_enrollment_no, book_id, book_name) Values(@student_enrollment_no, @book_id, @book_name)";
                List<SqlParameter[]> paramatersList = new();
                var parameters = new[]
                {
                    new SqlParameter("@student_enrollment_no", tb1.Text),
                    new SqlParameter("@book_id", lbx1.Text.Split("-")[0]),
                    new SqlParameter("@book_name", lbx1.Text.Split("-")[1].Trim()),
                };
                Model.ExecuteNonQuery(commandTxt, parameters);
                foreach (var item in lv2.Items)
                {
                    //buradaydin
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void Lbx1_DoubleClick(object sender, EventArgs e)
        {
            lbx1.Visible = false;
            tb2.Text = lbx1.Text.TrimEnd();
        }
    }
}
