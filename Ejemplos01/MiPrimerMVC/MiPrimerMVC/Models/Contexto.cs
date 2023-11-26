using Microsoft.EntityFrameworkCore;

namespace MiPrimerMVC.Models
{
    public class Contexto:DbContext
    {
        public Contexto()
        {

        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }
       public DbSet<Pajarito> Pajaritos { get; set; }
    }
}
