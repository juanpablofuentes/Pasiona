using Microsoft.EntityFrameworkCore;

namespace CapaServicio.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
    }
}
