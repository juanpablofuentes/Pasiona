using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    internal abstract class Figura
    {
        public string Nombre { get; set; }

        public abstract void Dibujar();
       // public abstract float area();
    }

    abstract class Figura2D : Figura
    {
        public abstract double area();
    }
    abstract class Figura3D : Figura2D
    {
        public abstract double volumen();
    }

    class Cuadrado : Figura2D
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Nombre = "Cuadrado";
            Lado = lado;
        }

        public override double area()
        {
            return Lado * Lado;
        }

        public override void Dibujar()
        {
            Console.WriteLine("□");
        }
    }

    class Circulo : Figura2D
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Nombre = "Círculo";
            Radio = radio;
        }

        public override double area()
        {
            return Math.PI*Radio*Radio;
        }

        public override void Dibujar()
        {
            Console.WriteLine("O");
        }
    }

}
