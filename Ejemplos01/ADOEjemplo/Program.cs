using Microsoft.Data.SqlClient;
using System.Data;

namespace ADOEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=ARP\\SQLEXPRESS;Initial Catalog=prueba;Integrated Security=True;TrustServerCertificate=True";


            connection.Open();
            string sql = "insert into alumno (nombre) values (@nombre)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nombre", "Ana Pi");
            
            command.ExecuteNonQuery();

            SqlCommand preparado = new SqlCommand(sql, connection);
            preparado.Parameters.Add("@nombre", SqlDbType.VarChar,50);
            preparado.Prepare();
            for(int i = 0; i < 10; i++)
            {
                command.Parameters["@nombre"].Value= "Alumno "+i;
                //command.ExecuteNonQuery();
            }
            sql = "select * from alumno";
            SqlCommand lectura=new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = lectura.ExecuteReader();
            while(sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader.GetInt32(0));
                Console.WriteLine(sqlDataReader["id"]);
                Console.WriteLine(sqlDataReader.GetString(1));
                Console.WriteLine(sqlDataReader["nombre"]);

            }

            sqlDataReader.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(row["id"]);
                Console.WriteLine(row["nombre"]);
            }



            connection.Close();
        }
    }
}