﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExampleSQLApp
{
    internal class DB
    {
        // Data Source=(localdb)\MSSQLLocalDB;
        // Initial Catalog=webform_db;
        // Integrated Security=True;
        // Connect Timeout=30;Encrypt=False;
        // TrustServerCertificate=False;
        // ApplicationIntent=ReadWrite;
        // MultiSubnetFailover=False
        SqlConnection connection = new SqlConnection("server=localhost;port=3306;username=root;password=root;database=webform_db");

        public void openConnection(string connectionString)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
                Console.WriteLine("Connection opened");
        }

        public void closeConnection(string connectionString)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
                Console.WriteLine("Connection closed");

        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}