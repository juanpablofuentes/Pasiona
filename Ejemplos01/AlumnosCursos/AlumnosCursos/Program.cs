using Microsoft.EntityFrameworkCore;

namespace AlumnosCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var contexto=new Contexto();
            //Curso daw = new Curso("DAW 2", 200);
            //contexto.Add(daw);
            //contexto.SaveChanges();
            Alumno ana = contexto.Alumnos.Where(x => x.Nombre == "Tiestillo").Include(x=>x.Curso).First();
            Curso c = contexto.Cursos.Where(x => x.Id == 3).Include(a=>a.Alumnos).First();
            //contexto.Add(ana);
            //contexto.SaveChanges();
            Console.WriteLine(contexto.Alumnos.Where(x=>x.Nombre=="Tiestillo").First().ToString());
            //List<Alumno> als = new List<Alumno>{new Alumno("Ana", "2", "ana@ana.com",daw),
            //         new Alumno("Eva", "2", "eva@eva.com",daw),
            //new Alumno("Juan", "2", "juan@juan.com",daw) };
            //contexto.AddRange(als);
            //contexto.SaveChanges();
            

        }
    }
}