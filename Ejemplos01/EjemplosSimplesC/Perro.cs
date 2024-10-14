using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal sealed class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        public override void sonido()
        {
            Console.WriteLine("Guaa guau");
        }
    }
}
