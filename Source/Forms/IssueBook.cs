using System.Data;
using System.Data.SqlClient;
using LibraryManagement.Source.Helpers;

namespace LibraryManagement
{
    public partial class IssueBookForm : Form
    {
        private List<SqlParameter[]> paramatersList = new();

        public IssueBookForm()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True; TrustServerCertificate=True;");
        }
        private void CheckStudentButton_Click(object sender, EventArgs e)
        {
            if (IsValidStudentSearch())
            {
                DisplayStudentInformation();
            }
            else
            {
                HideStudentInformation();
            }
        }
        private bool IsValidStudentSearch()
        {
            return !string.IsNullOrWhiteSpace(studentSearchTextBox.Text);
        }

        private void DisplayStudentInformation()
        {
            LoadIssuedBooksForStudent();
            ShowStudentInformationPanels();
        }
        private async void LoadIssuedBooksForStudent()
        {
            try
            {
                var issuedBooks = await FetchIssuedBooksAsync();
                PopulateIssuedBooksListView(issuedBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load issued books: " + ex.Message);
            }
        }
        private async Task<DataTable> FetchIssuedBooksAsync()
        {
            string query = "SELECT * FROM issue_books WHERE student_enrollment_no LIKE @student_enrollment_no";
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@student_enrollment_no", studentSearchTextBox.Text)
            };

            return await Task.Run(() => DatabaseHelper.ExecuteQuery(query, parameters));
        }
        private void PopulateIssuedBooksListView(DataTable issuedBooks)
        {
            lv1.Items.Clear();
            foreach (DataRow row in issuedBooks.Rows)
            {
                lv1.Items.Add($"{row["book_id"]}-{row["book_name"]}");
            }
        }
        private void ShowStudentInformationPanels()
        {
            pn1.Visible = true;
            lb4.Visible = true;
            lb5.Visible = true;
            lv1.Visible = true;
            lv2.Visible = true;
            bt3.Visible = true;
        }
        private void HideStudentInformation()
        {
            pn1.Visible = false;
            lb4.Visible = false;
            lb5.Visible = false;
            lv1.Visible = false;
            lv2.Visible = false;
            bt3.Visible = false;
        }


        private void UpdateChart()
        {
            DataTable issuedbooksDT = new();
            try
            {
                string commandTxt = "SELECT id FROM books_info WHERE name = @name";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", bookSearchTextBox.Text)
                };

                issuedbooksDT = DatabaseHelper.ExecuteQuery(commandTxt, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (issuedbooksDT.Rows.Count > 0)
            {
                DataRow row = issuedbooksDT.Rows[0];
                lv2.Items.Add(row["id"].ToString() + "-" + bookSearchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid entry!");
            }

        }
        private void AddToChartButtonClick(object sender, EventArgs e)
        {
            UpdateChart();
            bookSearchTextBox.Clear();
        }

        private SqlParameter[] GetParametersFromListView(ListViewItem listViewItem)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@student_enrollment_no", studentSearchTextBox.Text.TrimEnd()),
                new SqlParameter("@book_id", listViewItem.Text.Split('-')[0].Trim()),
                new SqlParameter("@book_name", listViewItem.Text.Split('-')[1].Trim()),
                new SqlParameter("@issue_date", dtp1.Text)
            };
        }
        private void IssueBooksButton_Click(object sender, EventArgs e)
        {
            try
            {
                paramatersList = new List<SqlParameter[]>();
                foreach (ListViewItem item in lv2.Items)
                {
                    string bookName = item.Text.Split('-')[1];
                    if (IsAvailable(bookName))
                    {
                        paramatersList.Add(GetParametersFromListView(item));
                    }
                    else
                    {
                        MessageBox.Show($"{bookName} is not available!");
                    }
                }

                string commandTxt = "Insert into issue_books(student_enrollment_no, book_id, book_name, issue_date) Values(@student_enrollment_no, @book_id, @book_name, @issue_date)";
                foreach (SqlParameter[] parameters in paramatersList)
                {
                    DatabaseHelper.ExecuteNonQuery(commandTxt, parameters);
                    var id = parameters[1].Value;
                    UpdateAvailable(id);
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
        private void UpdateAvailable(object id)
        {
            try
            {
                string commandTxt = "UPDATE books_info SET available = available - 1 WHERE ID = @id";
                DatabaseHelper.ExecuteNonQuery(commandTxt, new SqlParameter("@id", id));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsAvailable(string bookName)
        {
            DataTable issuedbooksDT = new();
            try
            {
                string commandTxt = "SELECT available FROM books_info WHERE name = @name";
                issuedbooksDT = DatabaseHelper.ExecuteQuery(commandTxt, new SqlParameter("@name", bookName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Convert.ToInt32(issuedbooksDT.Rows[0]["available"]) > 0;
        }
        private void SearchBook_KeyUp(object sender, KeyEventArgs e)
        {
            lbx1.Visible = true;

            try
            {
                DataTable issuedbooksDT = new();

                string query = "SELECT * FROM books_info WHERE name LIKE @name";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", "%" + bookSearchTextBox.Text + "%")
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
        private void ListViewBoxDoubleClick(object sender, EventArgs e)
        {
            lbx1.Visible = false;
            bookSearchTextBox.Text = lbx1.Text.TrimEnd();
        }
    }
}
