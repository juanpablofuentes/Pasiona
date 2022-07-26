using Microsoft.EntityFrameworkCore;
using Profesiones.Models;

namespace Profesiones.Models
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
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Profesiones.Models.Actividad>? Actividad { get; set; }
        public DbSet<Profesiones.Models.ProfesionalesActividades>? ProfesionalesActividades { get; set; }
    }
}
