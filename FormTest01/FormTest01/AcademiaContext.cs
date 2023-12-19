using Microsoft.EntityFrameworkCore;

namespace TestMVC.Models
{
    public class AcademiaContext:DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-B3NEDPH;Initial Catalog=pruebas;Integrated Security=True;TrustServerCertificate=True");
        }

    }
}
