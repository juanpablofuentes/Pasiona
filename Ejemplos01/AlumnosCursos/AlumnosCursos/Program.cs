namespace AlumnosCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var contexto=new Contexto();
            Curso daw = new Curso("DAW 2", 200);
            contexto.Add(daw);
            contexto.SaveChanges();
            Alumno ana = new Alumno("Ana", "2", "ana@ana.com", daw);
            contexto.Add(ana);
            contexto.SaveChanges();
            Console.WriteLine(ana);
            List<Alumno> als = new List<Alumno>{new Alumno("Ana", "2", "ana@ana.com",daw),
                     new Alumno("Eva", "2", "eva@eva.com",daw),
            new Alumno("Juan", "2", "juan@juan.com",daw) };
            contexto.AddRange(als);
            contexto.SaveChanges();
            

        }
    }
}