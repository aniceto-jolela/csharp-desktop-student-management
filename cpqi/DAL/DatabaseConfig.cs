using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace cpqi.DAL
{
    public static class DatabaseConfig
    {
        // String de conexão centralizada
        public static readonly string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CpqiDB;Integrated Security=True;Trust Server Certificate=True";

        // Método para criar a conexão
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
