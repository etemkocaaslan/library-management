using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
    internal static class DatabaseHelper
    {
        private static SqlConnection? connection;

        /// <summary>
        /// Initializes the database connection with the given connection string.
        /// </summary>
        /// <param name="connectionString">The database connection string.</param>
        public static void InitializeConnection(string connectionString)
        {
            connection ??= new SqlConnection(connectionString);
        }

        /// <summary>
        /// Executes a query and returns the result as a DataTable.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the SQL query.</param>
        /// <returns>DataTable with the query results.</returns>
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            EnsureConnection();
            DataTable dataTable = new DataTable();

            try
            {
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                using SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (SqlException e)
            {
                // Handle exceptions (or rethrow)
                throw new InvalidOperationException("Error executing query.", e);
            }

            return dataTable;
        }

        /// <summary>
        /// Executes a non-query command (e.g., UPDATE, INSERT, DELETE ).
        /// </summary>
        /// <param name="commandText">The command text to execute.</param>
        /// <param name="parameters">Optional parameters for the command.</param>
        /// <returns>The number of rows affected.</returns>
        public static int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
        {
            EnsureConnection();
            try
            {
                using SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                // Handle exceptions (or rethrow)
                throw new InvalidOperationException("Error executing non-query command.", e);
            }
        }

        /// <summary>
        /// Ensures that the connection is open and ready to use.
        /// </summary>
        private static void EnsureConnection()
        {
            if (connection == null)
                throw new InvalidOperationException("Connection must be initialized first.");

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        /// <summary>
        /// Gets the current SQL connection.
        /// </summary>
        public static SqlConnection? Connection => connection;
    }
}
