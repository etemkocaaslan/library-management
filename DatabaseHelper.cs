using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    internal static class DatabaseHelper
    {
        private static SqlConnection? connection;

        public static void InitializeConnection(string connectionString)
        {
            connection ??= new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            EnsureConnection();

            using SqlCommand command = new SqlCommand(query, connection);
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            using SqlDataAdapter adapter = new(command);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            EnsureConnection();

            using SqlCommand command = new(commandText, connection);
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command.ExecuteNonQuery();
        }

        private static void EnsureConnection()
        {
            if (connection == null)
                throw new InvalidOperationException("Connection must be initialized first.");

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }
        public static SqlConnection? Connection => connection;
    }

    internal static class FileManager
    {
        private static readonly string? image_path = ConfigurationManager.AppSettings["ImagePath"];
        private static readonly OpenFileDialog openImageFileDialog = new()
        {
            Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
            InitialDirectory = image_path,
            FileName = ""
        };

        public static Bitmap? GetImage()
        {
            return (openImageFileDialog.ShowDialog() == DialogResult.OK) ? new Bitmap(openImageFileDialog.FileName) : null;
        }
    }

}
