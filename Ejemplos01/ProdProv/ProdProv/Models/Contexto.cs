using Microsoft.EntityFrameworkCore;
using ProdProv.Models;

namespace ProdProv.Models
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

        public DbSet<Proveedor> Proveedores { get; set; }

        public DbSet<ProdProv.Models.Producto>? Producto { get; set; }


    }

}
