

namespace DAOAcademia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            DAOAlumno dao=new DAOAlumno();
            //List<Alumno> clase = dao.GetAll();
            //Console.WriteLine(String.Join(" | ",clase));

            //Alumno ana=new Alumno(1,"ANANANA","1111","@@");
            //Console.WriteLine(dao.Save(ana));
            //Alumno pepe = new Alumno(0, "Pepe", "1111", "@@");
            //Console.WriteLine(dao.Save(pepe));
            Console.WriteLine(dao.Delete(10));
        }
    }
}