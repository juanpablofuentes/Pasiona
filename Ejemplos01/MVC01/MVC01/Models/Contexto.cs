using Microsoft.EntityFrameworkCore;
using MVC01.Models;

namespace MVC01.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
        {

        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }

        public virtual DbSet<Alumno> Alumnos { get; set; }

        public DbSet<MVC01.Models.Curso>? Curso { get; set; }



    }
}
