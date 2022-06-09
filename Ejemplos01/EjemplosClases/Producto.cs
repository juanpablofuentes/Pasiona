using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosClases
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public decimal PVP { get { return Precio * 1.21M; } set { Precio = value / 1.21M; } }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
