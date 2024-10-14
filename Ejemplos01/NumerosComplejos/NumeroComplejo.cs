using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplejos
{
    public class NumeroComplejo:IComparable<NumeroComplejo>
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }

        // El cálculo del módulo lo encapsulamos dentro de una propiedad de solo lectura
        public double Modulo { get=> Math.Sqrt(ParteReal * ParteReal + ParteImaginaria * ParteImaginaria);}
        // Constructor
        public NumeroComplejo(double parteReal, double parteImaginaria)
        {
            ParteReal = parteReal;
            ParteImaginaria = parteImaginaria;
        }

        

        // Sobrecarga del operador de suma
        public static NumeroComplejo operator +(NumeroComplejo a, NumeroComplejo b)
        {
            return new NumeroComplejo(a.ParteReal + b.ParteReal, a.ParteImaginaria + b.ParteImaginaria);
        }

        // Sobrecarga del operador de resta
        public static NumeroComplejo operator -(NumeroComplejo a, NumeroComplejo b)
        {
            return new NumeroComplejo(a.ParteReal - b.ParteReal, a.ParteImaginaria - b.ParteImaginaria);
        }

        // Sobrecarga del operador de multiplicación
        public static NumeroComplejo operator *(NumeroComplejo a, NumeroComplejo b)
        {
            double real = a.ParteReal * b.ParteReal - a.ParteImaginaria * b.ParteImaginaria;
            double imaginaria = a.ParteReal * b.ParteImaginaria + a.ParteImaginaria * b.ParteReal;
            return new NumeroComplejo(real, imaginaria);
        }

        // Sobrecarga del operador de división
        public static NumeroComplejo operator /(NumeroComplejo a, NumeroComplejo b)
        {
            double denominador = b.ParteReal * b.ParteReal + b.ParteImaginaria * b.ParteImaginaria;
            double real = (a.ParteReal * b.ParteReal + a.ParteImaginaria * b.ParteImaginaria) / denominador;
            double imaginaria = (a.ParteImaginaria * b.ParteReal - a.ParteReal * b.ParteImaginaria) / denominador;
            return new NumeroComplejo(real, imaginaria);
        }


        // Sobrecarga de operadores de comparación
        public static bool operator <(NumeroComplejo a, NumeroComplejo b)
        {
            return a.Modulo < b.Modulo;
        }

        public static bool operator >(NumeroComplejo a, NumeroComplejo b)
        {
            return a.Modulo > b.Modulo;
        }

        public static bool operator <=(NumeroComplejo a, NumeroComplejo b)
        {
            return a.Modulo <= b.Modulo;
        }

        public static bool operator >=(NumeroComplejo a, NumeroComplejo b)
        {
            return a.Modulo >= b.Modulo;
        }

        // Sobrecarga de operadores de igualdad
        public static bool operator ==(NumeroComplejo a, NumeroComplejo b)
        {
            return a.ParteReal == b.ParteReal && a.ParteImaginaria == b.ParteImaginaria;
        }

        public static bool operator !=(NumeroComplejo a, NumeroComplejo b)
        {
            return !(a == b);
        }

        // Sobrecarga de operadores unarios
        public static NumeroComplejo operator -(NumeroComplejo a)
        {
            return new NumeroComplejo(-a.ParteReal, -a.ParteImaginaria);
        }
        public override string ToString()
        {
            return ParteReal+" + "+ParteImaginaria+"i";
        }

        // Sobrecarga de Hashcode
        public override int GetHashCode()
        {
            // Utilizamos el propio método de combinar que nos garantiza una función estable y bien estructurada
            return HashCode.Combine(ParteImaginaria, ParteReal);
        }

        // Sobrecargamos equals que suele ir relacionado con hashcode: nos servirá para que al usarlos como clave se reconozcan como iguales
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            NumeroComplejo other = (NumeroComplejo)obj;
            // Nos aprovechamos de que ya tenemos el operador == sobrecargado
            return this == other;
        }
        public int CompareTo(NumeroComplejo? other)
        {
            return this.Modulo.CompareTo(other?.Modulo);
        }
    }
}
