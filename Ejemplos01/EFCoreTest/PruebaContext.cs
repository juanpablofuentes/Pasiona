using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class PruebaContext: DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-B3NEDPH;Initial Catalog=pruebas;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
