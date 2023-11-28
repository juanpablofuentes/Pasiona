using Microsoft.Data.SqlClient;

namespace ADOEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=pruebas;Integrated Security=True;TrustServerCertificate=True";


            connection.Open();
            string sql = "insert into alumno (nombre) values (@nombre)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nombre", "Ana Pi");
            
            command.ExecuteNonQuery();
            

            connection.Close();
        }
    }
}