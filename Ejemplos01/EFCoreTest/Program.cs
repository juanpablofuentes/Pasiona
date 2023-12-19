namespace EFCoreTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PruebaContext())
            {
                var nuevo = new Profesor { NombreCompleto = "Juan Pérez", Email = "juan@example.com" };
                context.Profesores.Add(nuevo);
                context.SaveChanges();
            }
        }
    }
}