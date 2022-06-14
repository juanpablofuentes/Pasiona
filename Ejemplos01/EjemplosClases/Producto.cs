using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosClases
{
    internal class Producto : IRebaja
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public static decimal IVA { get { return .21M; } }

        public decimal PVP { get { return Precio * (1 + IVA); } set { Precio = value / (1 + IVA); } }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public override string ToString()
        {
            return Nombre + Precio;
        }

        public virtual string etiqueta()
        {
            return "Nombre: " + Nombre + " cuesta " + Precio;
        }
        public virtual decimal Rebaja()
        {
            return Precio * .9M;
        }
    }
    class Libro : Producto
    {
        public string Titulo { get; set; }
        public Libro(string nombre, decimal precio, string titulo) : base(nombre, precio)
        {
            Titulo = titulo;
        }
        public override string ToString()
        {
            return base.ToString() + Titulo;
        }
        public override string etiqueta()
        {
            return "Título: " + Titulo + " cuesta " + Precio; ;
        }
        public new decimal Rebaja()
        {
            return Precio * .95M;
        }
        public string Calidad()
        {
            return "Muy bueno";
        }
    }
    class Manzana : Producto
    {
        public Manzana(string nombre, decimal precio) : base(nombre, precio)
        {
        }
        public override string etiqueta()
        {
            return Nombre + " cuesta " + Precio + " el kilo."; ;
        }

    }
}
