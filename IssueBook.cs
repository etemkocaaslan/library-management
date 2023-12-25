using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace WinFormsApp2
{
    public partial class IssueBook : Form
    {
        private List<SqlParameter[]> paramatersList = new();

        public IssueBook()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }

        private void BarrowedCheck()
        {
            DataTable issuedbooksDT = new();
            try
            {
                string query = "SELECT * FROM issue_books WHERE student_enrollment_no LIKE @student_enrollment_no";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@student_enrollment_no", tb1.Text)
                };

                issuedbooksDT = DatabaseHelper.ExecuteQuery(query, parameters);
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

        private void UpdateChart()
        {
            DataTable issuedbooksDT = new();
            try
            {
                string query = "SELECT id FROM books_info WHERE name = @name";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", tb2.Text)
                };

                issuedbooksDT = DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
            if(issuedbooksDT.Rows.Count > 0) {
                DataRow row = issuedbooksDT.Rows[0];
                lv2.Items.Add(row["id"].ToString() + "-" + tb2.Text);
            }
            else
            {
                MessageBox.Show("Invalid entry!");
            }
            
        }

        private void Tb2KeyUp(object sender, KeyEventArgs e)
        {
            lbx1.Visible = true;

            try
            {
                DataTable issuedbooksDT = new();

                string query = "SELECT * FROM books_info WHERE name LIKE @name";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", "%" + tb2.Text + "%")
                };
                issuedbooksDT = DatabaseHelper.ExecuteQuery(query, parameters);

                lbx1.Items.Clear();
                foreach (DataRow row in issuedbooksDT.Rows)
                {
                    lbx1.Items.Add(row[columnName: "name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void Bt1_Click(object sender, EventArgs e)
        {
            if (tb1.TextLength > 0)
            {
                DataTable paramatersList = new();
                try
                {
                    string query = "SELECT * FROM Student WHERE enrollment_no LIKE @enrollment_no";
                    SqlParameter[] parameters = new[]
                    {
                        new SqlParameter("@enrollment_no", tb2.Text)
                    };

                    paramatersList = await Task.Run(() => DatabaseHelper.ExecuteQuery(query, parameters));
                    pn1.Visible = true;

                    lv1.Clear();
                    BarrowedCheck();
                    lb4.Visible = true;
                    lb5.Visible = true;
                    lv1.Visible = true;
                    lv2.Visible = true;
                    bt3.Visible = true;
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
                bt3.Visible = false;
            }

        }
        private void Bt2_Click(object sender, EventArgs e)
        {
            UpdateChart();
            tb2.Clear();
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            try
            {
                string commandTxt = "Insert into issue_books(student_enrollment_no, book_id, book_name) Values(@student_enrollment_no, @book_id, @book_name)";
                paramatersList = new List<SqlParameter[]>();

                foreach (ListViewItem item in lv2.Items)
                {
                    paramatersList.Add(GetSqlParameter(item));
                }

                foreach (SqlParameter[] parameters in paramatersList)
                {
                    DatabaseHelper.ExecuteNonQuery(commandTxt, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pn1.Visible = false;
            lv2.Clear();
            lb1.Refresh();
        }
        private SqlParameter[] GetSqlParameter(ListViewItem listViewItem)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@student_enrollment_no", tb1.Text.TrimEnd()),
                new SqlParameter("@book_id", listViewItem.SubItems[1].Text.TrimEnd()),
                new SqlParameter("@book_name", listViewItem.Text.TrimEnd())
            };
        }

        private void Lbx1_DoubleClick(object sender, EventArgs e)
        {
            lbx1.Visible = false;
            tb2.Text = lbx1.Text.TrimEnd();
        }
    }
}
