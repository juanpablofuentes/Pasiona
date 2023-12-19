using Microsoft.EntityFrameworkCore;

namespace TestMVC.Models
{
    public class AcademiaContext:DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
        }
    }
}
