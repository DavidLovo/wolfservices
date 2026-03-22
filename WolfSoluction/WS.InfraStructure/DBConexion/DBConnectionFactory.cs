using System;
using System.Collections.Generic;
using System.Text;

namespace WS.InfraStructure.DBConexion
{
    public class DBConnectionFactory
    {
        private readonly string _connectionString;

        public DBConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

       
    }
}
