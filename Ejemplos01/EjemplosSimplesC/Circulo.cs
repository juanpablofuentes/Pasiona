using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal class Circulo : Figura
    {
        public Double radio { get; set; }
        public double area()
        {
            return Math.PI * radio*radio;
        }
    }
}
