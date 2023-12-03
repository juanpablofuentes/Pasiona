using System.Data.SqlClient;

namespace DAOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adao = new AlumnoDAO(ConnectionDB.connection);
            Alumno pepe = adao.getAlumno(2);
            pepe.Nombre = "Pepe";
            Console.WriteLine(adao.deleteAlumno(pepe));
        }
    }
}