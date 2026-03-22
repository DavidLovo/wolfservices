using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace WS.InfraStructure.DBConexion
{
    public class DBConnectionFactory
    {
        private readonly string _connectionString;

        public DBConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
       
    }
}
