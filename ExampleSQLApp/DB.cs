﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;



namespace test_DB
{
    internal class DataBase
    {
        readonly SqlConnection connection = new SqlConnection(@"Data Source=novice\sqlexpress;
                                                                Initial Catalog=miit_local;
                                                                Integrated Security=True");

/*        public void OpenConnection(string connectionString)*/
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
                Console.WriteLine("Connection open");
        }

/*        public void CloseConnection(string connectionString)*/
        public void CloseConnection()
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
