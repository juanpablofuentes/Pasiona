using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOExample
{
    internal class AlumnoDAO : IAlumnoDAO
    {
        public SqlConnection connection { get; set; }
        private int limite = 10;
        public AlumnoDAO(SqlConnection connection)
        {
            this.connection = connection;
        }
        private Alumno createAlumno(SqlDataReader reader)
        {
            try
            {
                var idDb = reader.GetInt32(0);
                var nombre = reader.GetString(1) ?? "";
                var nota = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                var inscripcion = reader.GetDateTime(3);
                var email = reader.IsDBNull(4) ? "" : reader.GetString(4);
                return new Alumno(idDb, nombre, nota, inscripcion, email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Alumno getAlumno(int id)
        {
            try
            {
                var sql = "select id,nombre,nota,ISNULL(inscripcion, getdate()),email from alumno where id=@id";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return createAlumno(reader);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally { connection.Close(); }
        }

        public Alumno getAlumno(string name)
        {
            try
            {
                var sql = "select id,nombre,nota,ISNULL(inscripcion, getdate()),email from alumno where nombre=@name";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return createAlumno(reader);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally { connection.Close(); }
        }
        public List<Alumno> getAll()
        {
            return getAll(limite);
        }
        public List<Alumno> getAll(int limite, int pagina = 0)
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>();
                var sql = "select id,nombre,nota,ISNULL(inscripcion, getdate()),email from alumno order by id OFFSET @offset ROWS FETCH NEXT @records ROWS ONLY;";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@offset", pagina * limite);
                command.Parameters.AddWithValue("@records", limite);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    alumnos.Add(createAlumno(reader));
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally { connection.Close(); }
        }
        public List<Alumno> getAll(string nombre)
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>();
                var sql = "select id,nombre,nota,ISNULL(inscripcion, getdate()),email from alumno where nombre like @nombre order by id ";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", $"%{nombre}%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    alumnos.Add(createAlumno(reader));
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally { connection.Close(); }
        }
        public int addAlumno(Alumno alumno)
        {
            try
            {
                var sql = "insert into alumno (nombre,nota,inscripcion,email) OUTPUT INSERTED.ID values (@nombre,@nota,@inscripcion,@email)";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nombre", alumno.Nombre);
                command.Parameters.AddWithValue("@nota", alumno.Nota);
                command.Parameters.AddWithValue("@inscripcion", alumno.Inscripcion.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@email", alumno.Email);
                int id = (int) command.ExecuteScalar();
                
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally { connection.Close(); }
        }

        public int deleteAlumno(int id)
        {
            try
            {
                var sql = "delete from alumno where id=@id";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally { connection.Close(); }
        }
    

        public int deleteAlumno(Alumno alumno)
        {
        try
        {
            var sql = "delete from alumno where id=@id";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", alumno.Id);
            return command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
        finally { connection.Close(); }
    }




        public int updateAlumno(Alumno alumno)
        {
            try
            {
                var sql = "update alumno set nombre=@nombre,nota=@nota,inscripcion=@inscripcion,email=@email where id=@id";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", alumno.Id);
                command.Parameters.AddWithValue("@nombre", alumno.Nombre);
                command.Parameters.AddWithValue("@nota", alumno.Nota);
                command.Parameters.AddWithValue("@inscripcion", alumno.Inscripcion.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@email", alumno.Email);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally { connection.Close(); }
        }
    }
}
