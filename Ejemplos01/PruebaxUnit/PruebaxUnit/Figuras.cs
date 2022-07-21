using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaxUnit
{
    public class Cuadrado
    {
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double lado { get; set; }

        public double area()
        {
            if (lado < 0) throw new Exception("Lado incorrecto");
            return lado * lado;
        }
    }
}
