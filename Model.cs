using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    internal static class Model
    {
        private static SqlConnection? connection;
        private static readonly string image_path = @"C:\Users\kasla\MyProjects\library_management\WinFormsApp2\images\";
        private static MemoryStream? memoryStream;
        private static readonly OpenFileDialog openImageFileDialog = new()
        {
            Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
            InitialDirectory = image_path,
            FileName = ""
        };

        public static void InitializeConnection(string connectionString)
        {
            connection ??= new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            EnsureConnection();
            using var command = new SqlCommand(query, connection);
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            using var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            EnsureConnection();
            using SqlCommand command = new(commandText, connection);
            foreach (var parameter in parameters)
                command.Parameters.Add(parameter);

            return command.ExecuteNonQuery();
        }

        private static void EnsureConnection()
        {
            if (connection == null)
                throw new InvalidOperationException("Connection must be initialized first.");

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }
        public static Bitmap? GetImage()
        {
            return (openImageFileDialog.ShowDialog() == DialogResult.OK) ? new Bitmap(openImageFileDialog.FileName) : null;
        }
        public static SqlConnection? Connection => connection;
    }
}
