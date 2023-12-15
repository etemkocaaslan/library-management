using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    internal static class Model
    {
        private static SqlConnection? connection;

        public static void InitializeConnection(string connectionString)
        {
            connection ??= new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query)
        {
            EnsureConnection();
            using var command = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static int ExecuteNonQuery(string commandText)
        {
            EnsureConnection();
            using SqlCommand? command = new(commandText, connection);
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
}
