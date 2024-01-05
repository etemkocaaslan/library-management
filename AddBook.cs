using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Add Book button click.
        /// </summary>
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                AddBookToDatabase();
            }
        }

        private bool ValidateInputFields()
        {
            var errors = new List<string>(); // Accumulate error messages

            ValidateTextField(nameTextBox.Text, "book name", errors);
            ValidateTextField(authorTextBox.Text, "author's name", errors);
            ValidateTextField(publisherTextBox.Text, "publisher's name", errors);
            ValidateNumberField(priceTextBox.Text, "price", errors);
            ValidateNumberField(quantityTextBox.Text, "quantity", errors);

            // Additional validations..
            if (errors.Any())
            {
                // Display % log the errors
                MessageBox.Show(string.Join("\n", errors), "Validation Errors");
                return false;
            }

            return true;
        }

        // Validates if the text field is not empty or null
        private void ValidateTextField(string fieldValue, string fieldName, List<string> errors)
        {
            if (string.IsNullOrWhiteSpace(fieldValue))
            {
                errors.Add($"Please enter the {fieldName}.");
            }
        }

        // Validates if the number field is a valid number
        private void ValidateNumberField(string fieldValue, string fieldName, List<string> errors)
        {
            if (string.IsNullOrWhiteSpace(fieldValue) || !decimal.TryParse(fieldValue, out _))
            {
                errors.Add($"Please enter a valid {fieldName}.");
            }
        }

        /// <summary>
        /// Adds a new book to the database using the values from the form's text fields.
        /// </summary>
        private void AddBookToDatabase()
        {
            try
            {
                string commandTxt = "INSERT INTO books_info(name, author, publisher, purchase_date, price, quantity) VALUES(@name, @author, @publisher, @purchase_date, @price, @quantity)";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@name", nameTextBox.Text),
                    new SqlParameter("@author", authorTextBox.Text),
                    new SqlParameter("@publisher", publisherTextBox.Text),
                    new SqlParameter("@purchase_date", purchaseDatePicker.Value.ToString("yyyy-MM-dd")), // Assuming dtp1 is a DateTimePicker
                    new SqlParameter("@price", priceTextBox.Text),
                    new SqlParameter("@quantity", quantityTextBox.Text),
                };

                DatabaseHelper.ExecuteNonQuery(commandTxt, parameters);
                MessageBox.Show("Books are added successfully");
                ClearTextFields();
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL specific exceptions or show a user-friendly message
                MessageBox.Show("An error occurred while adding the book. Please try again.");
            }
            catch (Exception ex)
            {
                // General exception handling or logging
                MessageBox.Show($"{ex.Message}");
            }
        }

        /// <summary>
        /// Clears all text fields on the form.
        /// </summary>
        private void ClearTextFields()
        {
            nameTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
        }
    }
}
