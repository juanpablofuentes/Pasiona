using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInicio
{
    internal class Contexto : DbContext
    {
        public DbSet<Pajaro> Pajaros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=aviario;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
