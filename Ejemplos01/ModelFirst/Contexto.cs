using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    internal class Contexto:DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=prueba;Trusted_Connection=True;");
            }
        }
    }
}
}
