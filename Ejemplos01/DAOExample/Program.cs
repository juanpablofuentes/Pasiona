using System.Data.SqlClient;

namespace DAOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adao = new AlumnoDAO(ConnectionDB.connection);
            var alumnos = adao.getAll("a");
            foreach (var alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }
            Alumno pep = new Alumno(0, "Pep Bou", 6, DateTime.Now, "pepe@pepe.com");
            int id=adao.addAlumno(pep);
            Console.WriteLine(id);
            var ana = adao.getAlumno(30);
           
            if (adao.deleteAlumno(ana) > 0)
            {
                Console.WriteLine("Registro eliminado");
            }
            else
            {
                Console.WriteLine("No se ha eliminado nada");
            }
        }
    }
}