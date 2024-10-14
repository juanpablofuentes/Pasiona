using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal abstract class Animal
    {
        public String Nombre { get; set; }

        public Animal(String nombre) { 
            Nombre = nombre;
        }
        // Al crear un método como abstracto lo que hago es
        // obligar a todas las clases derivadas a que hagan
        // una implementación de este método
        public abstract void sonido();
    }
}
