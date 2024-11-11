using Microsoft.Data.SqlClient;
using System.Data;

namespace ADOEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var connection = new SqlConnection();
                connection.ConnectionString = "Data Source=.\\SQLEXPRESS;" +
                    "Initial Catalog=pasiona;Integrated Security=True;" +
                    "TrustServerCertificate=True";
                String nombre = "pepito2');delete from alumno where id=('6";
                
                connection.Open();
                Console.WriteLine("Conectado");
                /*
                string sql = "INSERT INTO profesor (nombre) VALUES ('"+nombre+"')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                // Para evitar inyección sql se usan parámetros
                nombre = "pepito3');delete from alumno where id=('7";
                sql = "insert into alumno (nombre) values (@nombre)";
                  command = new SqlCommand(sql, connection);
                 command.Parameters.AddWithValue("@nombre", nombre);

                 command.ExecuteNonQuery();
                
                 sql = "update alumno set nombre=@nombre where id=@id";
                 command = new SqlCommand(sql, connection);

                 command.Parameters.AddWithValue("@nombre", "Esmeralda García");
                 command.Parameters.AddWithValue("@id", 3);
                 command.ExecuteNonQuery();

                 sql = "delete from alumno  where id=@id";
                 command = new SqlCommand(sql, connection);

                 command.Parameters.AddWithValue("@id", 8);
                 int n=command.ExecuteNonQuery();
                
                 sql = "insert into alumno (nombre) values (@nombre)";
                 SqlCommand preparado = new SqlCommand(sql, connection);
                 // Añado el parámetro que voy a usar con su tipo
                 preparado.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                 preparado.Prepare();
                 for (int i = 0; i < 10; i++)
                 {
                     command.Parameters["@nombre"].Value = "Alumno " + i;
                   //  command.ExecuteNonQuery();
                 }
               */
                String sql = "select id, nombre from alumno";
                SqlCommand lectura = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = lectura.ExecuteReader();
                while ( sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader.GetInt32(0));
                    int id = (int)sqlDataReader["id"];
                    Console.WriteLine(sqlDataReader["id"]);
                    Console.WriteLine(sqlDataReader.GetString(1));
                    Console.WriteLine(sqlDataReader["nombre"]);
                }

                sqlDataReader.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Console.WriteLine(row["id"]);
                    Console.WriteLine(row["nombre"]);
                }
                  


                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}