using System;
using System.Data.SqlClient;

namespace MyTodoListApp
{
    public class MyMSSqlConnection
    {
        private static MyMSSqlConnection _instance;
        private SqlConnection _connection;
        private static readonly object _lock = new object();
        private string _connectionString = @"Data Source=MichaelRhey\SQLEXPRESS;Initial Catalog=MyFirstTestDb;Integrated Security=True;Encrypt=False";

        // Private constructor to initialize the connection
        private MyMSSqlConnection()
        {
            _connection = new SqlConnection(_connectionString);
        }

        // Public method to get the singleton instance
        public static MyMSSqlConnection GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MyMSSqlConnection();
                    }
                }
            }
            return _instance;
        }

        // Method to get the SQL connection
        public SqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        // Optional method to close the connection
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
