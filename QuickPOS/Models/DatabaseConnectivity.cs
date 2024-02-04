using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace QuickPOS.Models
{
  

    public class DatabaseConnectivity
    {
        private MySqlConnection connection;
        private string connectionString;

        public DatabaseConnectivity()
        {
            // Set your MySQL connection string
            connectionString = "Server=localhost:3307;Database=sales;User ID=root;Password=;";

            // Initialize the MySqlConnection object
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Add your database operations here using the 'connection' object

        // Example query execution method:
        public MySqlDataReader ExecuteQuery(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            // Do not close the connection here to allow the calling code to manage it
            return reader;
        }
    }
}