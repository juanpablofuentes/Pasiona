using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOExample
{
    internal class ConnectionDB
    {
        public static SqlConnection connection = new SqlConnection("Data Source=ARP\\SQLEXPRESS;Initial Catalog=prueba;Integrated Security=True;TrustServerCertificate=True");
    }
}
