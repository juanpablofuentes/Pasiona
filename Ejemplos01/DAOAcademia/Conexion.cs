using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOAcademia
{
    internal class Conexion
    {
        public static SqlConnection getConn()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.\\SQLEXPRESS;" +
                "Initial Catalog=pasiona;Integrated Security=True;" +
                "TrustServerCertificate=True";
            return connection;
        }
    }
}
