using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace LibraryManagement
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            studentPictureBox.Image = FileManager.GetImage();
        }

        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            studentPictureBox.Image = null;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (ValidateStudentFields())
            {
            try
            {
            AddStudentToDatabase();
            MessageBox.Show("Student is added successfully");
            ClearStudentFields();
            }
            catch (Exception ex)
            {
            MessageBox.Show("Failed to add student: " + ex.Message);
            }
            }

        }
        private bool ValidateStudentFields()
        {
            var errorMessages = new List<string>();

            ValidateTextField(nameTextBox.Text, "Name", errorMessages);
            ValidateTextField(enrollmentNoTextBox.Text, "Enrollment No", errorMessages);
            ValidateTextField(departmentTextBox.Text, "Department", errorMessages);
            ValidateTextField(semTextBox.Text, "SEM", errorMessages);
            ValidateTextField(contactTextBox.Text, "Contact", errorMessages);
            ValidateTextField(emailTextBox.Text, "Email", errorMessages);
            ValidateImage(studentPictureBox.Image, "Student Image", errorMessages);

            if (errorMessages.Any())
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Validation Error");
                return false;
            }

            return true;
        }
        private void ValidateTextField(string input, string fieldName, List<string> errorMessages)
        {
            if (string.IsNullOrWhiteSpace(input))
                errorMessages.Add($"Please enter {fieldName}.");
        }
        private void ValidateImage(Image image, string fieldName, List<string> errorMessages)
        {
            if (image == null)
                errorMessages.Add($"Please add {fieldName}.");
        }
        private void AddStudentToDatabase()
        {
            using var memoryStream = new MemoryStream();
            studentPictureBox.Image.Save(memoryStream, ImageFormat.Jpeg);

            string sql = "INSERT INTO Student(name, enrollment_no, department, sem, contact, email, image) VALUES(@name, @enrollment_no, @department, @sem, @contact, @email, @image)";
            SqlParameter[] parameters = new[]
            {
                    new SqlParameter("@name", nameTextBox.Text),
                    new SqlParameter("@enrollment_no", enrollmentNoTextBox.Text),
                    new SqlParameter("@department", departmentTextBox.Text),
                    new SqlParameter("@sem", semTextBox.Text),
                    new SqlParameter("@contact", contactTextBox.Text),
                    new SqlParameter("@email", emailTextBox.Text),
                    new SqlParameter("@image", memoryStream.ToArray())
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        private void ClearStudentFields()
        {
            nameTextBox.Clear();
            enrollmentNoTextBox.Clear();
            departmentTextBox.Clear();
            contactTextBox.Clear();
            emailTextBox.Clear();
            semTextBox.Clear();
            studentPictureBox.Image = null;
        }
    }

}
