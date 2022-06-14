using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    internal class Animal
    {
        public Animal(string nombre, string especie)
        {
            Nombre = nombre;
            Especie = especie;
        }

        public string Nombre { get; set; }
        public string Especie { get; set; }

        public virtual string Sonido()
        {
            return "Grrrr";
        }
    }
    class Mamifero : Animal
    {
        public string Pelaje { get; set; }
        public Mamifero(string nombre, string especie) : base(nombre, especie)
        {
            Pelaje = "";
        }
     
    }
    sealed class Perro : Mamifero, IDraw
    {
        public string Raza { get; set; }
        public Perro(string nombre) : base(nombre, "Canis canis")
        {
        }
        public override string Sonido()
        {
            return "Guau";
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
    //class FoxTerrier : Perro
    //{

    //}
}
