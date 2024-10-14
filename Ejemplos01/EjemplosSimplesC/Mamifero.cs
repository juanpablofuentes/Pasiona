using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal abstract class Mamifero : Animal
    {
        protected Mamifero(string nombre) : base(nombre)
        {
        }
    }
}
