using System.Data.SqlClient;
using System.Drawing.Imaging;
using LibraryManagement.Source.Helpers;

namespace LibraryManagement
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            DatabaseHelper.InitializeConnection("Data Source=DESKTOP-SR937O1;Initial Catalog=libmanag;Integrated Security=True");
        }


        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            studentPictureBox.Image = FileManager.GetImage();
        }

        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            ClearImage();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (ValidateStudentFields())
            {
                AddStudent();
            }
        }
        private void AddStudent()
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

        private bool ValidateStudentFields()
        {
            var errorMessages = new List<string>(); // Accumulate error messages

            ValidateTextField(nameTextBox.Text, "Name", errorMessages);
            ValidateTextField(enrollmentNoTextBox.Text, "Enrollment No", errorMessages);
            ValidateTextField(departmentTextBox.Text, "Department", errorMessages);
            ValidateTextField(semTextBox.Text, "SEM", errorMessages);
            ValidateTextField(contactTextBox.Text, "Contact", errorMessages);
            ValidateTextField(emailTextBox.Text, "Email", errorMessages);
            ValidateImage(studentPictureBox.Image, "Student Image", errorMessages);

            // Additional validations...
            if (errorMessages.Any())
            {
                // Display % log the errors
                MessageBox.Show(string.Join("\n", errorMessages), "Validation Error");
                return false;
            }

            return true;
        }
        // Validates if the text field is not empty or null
        private void ValidateTextField(string input, string fieldName, List<string> errorMessages)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessages.Add($"Please enter {fieldName}.");
            }
        }

        // Validates if the number field is a valid number
        private void ValidateImage(Image image, string fieldName, List<string> errorMessages)
        {
            if (image == null)
            {
                errorMessages.Add($"Please add {fieldName}.");
            }
        }

        /// <summary>
        /// Adds a new book to the database using the values from the form's text fields.
        /// </summary>
        private void AddStudentToDatabase()
        {
            try
            {
                var imageData = ConvertImageToByteArray(studentPictureBox.Image);

                string sql = "INSERT INTO Student(name, enrollment_no, department, sem, contact, email, image) VALUES(@name, @enrollment_no, @department, @sem, @contact, @email, @image)";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", nameTextBox.Text),
                    new SqlParameter("@enrollment_no", enrollmentNoTextBox.Text),
                    new SqlParameter("@department", departmentTextBox.Text),
                    new SqlParameter("@sem", semTextBox.Text),
                    new SqlParameter("@contact", contactTextBox.Text),
                    new SqlParameter("@email", emailTextBox.Text),
                    new SqlParameter("@image", imageData)
            };

                DatabaseHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                // General exception handling or logging
                MessageBox.Show($"{ex.Message}");
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using var memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        /// <summary>
        /// Clears all text and image fields on the form.
        /// </summary>
        private void ClearStudentFields()
        {
            nameTextBox.Clear();
            enrollmentNoTextBox.Clear();
            departmentTextBox.Clear();
            contactTextBox.Clear();
            emailTextBox.Clear();
            semTextBox.Clear();
            ClearImage();
        }
        private void ClearImage()
        {
            studentPictureBox.Image = null;
        }
    }

}
