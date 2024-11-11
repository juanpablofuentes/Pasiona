using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAOAcademia
{

    internal class DAOAlumno:IDAO<Alumno>
    {
        SqlConnection conn;
        public DAOAlumno() {
            conn=Conexion.getConn();
        }

        public int Delete(int id)
        {
            try
            {
                conn.Open();
                String sql = "delete alumno where id=@id";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@id", id);

                int res = comando.ExecuteNonQuery();

                conn.Close();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public List<Alumno> GetAll()
        {
            try
            {
                conn.Open();
                String sql = "select * from alumno";
                SqlCommand lectura = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = lectura.ExecuteReader();
                List<Alumno> alumnos= new List<Alumno>();
                while (sqlDataReader.Read())
                {
                    Alumno alumno = new Alumno(sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1) ?? "",
                        sqlDataReader.GetString(2)??"",
                        sqlDataReader.GetString(3)??""
                        );
                    alumnos.Add( alumno );
                }
                conn.Close();
                return alumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Alumno GetById(int id)
        {
            Alumno alumno = null;
            try
            {
                conn.Open();
                String sql = "select *from alumno where id=@id";
                SqlCommand lectura = new SqlCommand(sql, conn);
                lectura.Parameters.AddWithValue("@id", id);
                SqlDataReader sqlDataReader = lectura.ExecuteReader();
                
                if (sqlDataReader.Read())
                {
                    alumno = new Alumno(sqlDataReader.GetInt32(0),
                        sqlDataReader[1] as string ??"",
                        sqlDataReader.GetString(2) ?? "",
                        sqlDataReader.GetString(3) ?? ""
                        );
                    
                }
                conn.Close();
                return alumno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return alumno;
            }
        }

        public int Insert(Alumno alumno)
        {
            
            try
            {
                conn.Open();
                String sql = "insert into alumno (nombre,dni,email) values (@nombre,@dni,@email)";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@dni", alumno.DNI);
                comando.Parameters.AddWithValue("@email", alumno.Email);
                
                int res = comando.ExecuteNonQuery();

                conn.Close();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int Save(Alumno alumno)
        {
            if (alumno.Id == 0)
            {
                return Insert(alumno);
            }
            else
            {
                return Update(alumno);
            }
        }

        public int Update(Alumno alumno)
        {
            try
            {
                conn.Open();
                String sql = "update alumno set nombre=@nombre,dni=@dni,email=@email where id=@id";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@dni", alumno.DNI);
                comando.Parameters.AddWithValue("@email", alumno.Email);
                comando.Parameters.AddWithValue("@id", alumno.Id);

                int res = comando.ExecuteNonQuery();

                conn.Close();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
