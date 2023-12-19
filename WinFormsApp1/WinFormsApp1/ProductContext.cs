using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1,  Name = "Cheddar" },
                new Product { ProductId = 2,  Name = "Brie" },
                new Product { ProductId = 3,  Name = "Stilton" },
                new Product { ProductId = 4,  Name = "Cheshire" },
                new Product { ProductId = 5,  Name = "Swiss" },
                new Product { ProductId = 6,  Name = "Gruyere" },
                new Product { ProductId = 7,  Name = "Colby" },
                new Product { ProductId = 8,  Name = "Mozzela" },
                new Product { ProductId = 9,  Name = "Ricotta" },
                new Product { ProductId = 10,  Name = "Parmesan" },
                new Product { ProductId = 11,  Name = "Ham" },
                new Product { ProductId = 12,  Name = "Beef" },
                new Product { ProductId = 13,  Name = "Chicken" },
                new Product { ProductId = 14,  Name = "Turkey" },
                new Product { ProductId = 15,  Name = "Prosciutto" },
                new Product { ProductId = 16,  Name = "Bacon" },
                new Product { ProductId = 17,  Name = "Mutton" },
                new Product { ProductId = 18,  Name = "Pastrami" },
                new Product { ProductId = 19,  Name = "Hazlet" },
                new Product { ProductId = 20,  Name = "Salami" });
        }
    }
}
