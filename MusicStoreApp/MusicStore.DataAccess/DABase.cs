using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    public class DABase
    {
        public string _connectionString;
        public SqlConnection _connection;
        public DABase()
        {
            _connectionString = DbConnectionObj.GetConnectionString();
            _connection = new SqlConnection(_connectionString);
        }
    }
}
