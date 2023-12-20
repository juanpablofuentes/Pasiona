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
                connection.ConnectionString = "Data Source=ARP\\SQLEXPRESS;Initial Catalog=prueba;Integrated Security=True;TrustServerCertificate=True";
                String nombre = "pepito');delete from alumno where id=('1";
                connection.Open();
                
                // Para evitar inyección sql se usan parámetros
               /*
                string sql = "insert into alumno (nombre) values (@nombre)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                
                command.ExecuteNonQuery();
                sql = "update alumno set nombre=@nombre where id=@id";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@nombre", "Esmeralda García");
                command.Parameters.AddWithValue("@id", 3);
                command.ExecuteNonQuery();

                sql = "delete from alumno  where id=@id";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", 5);
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
                string sql = "select id, nombre from alumno";
                SqlCommand lectura = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = lectura.ExecuteReader();
                while (false && sqlDataReader.Read())
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