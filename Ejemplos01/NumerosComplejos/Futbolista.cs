using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplejos
{
    internal class Futbolista:IComparable<Futbolista>
    {
        public String Nombre { get; set; }
        public int Goles { get; set; }
        public Futbolista(String nombre, int goles) { 
            Nombre=nombre;
            Goles=goles;
        }

        public static Futbolista operator +(Futbolista a, int b)
        {
            return new Futbolista(a.Nombre,a.Goles+b);
        }
        public static Futbolista operator ++(Futbolista a)
        {
            return new Futbolista(a.Nombre, a.Goles + 1);
        }
        // Sobrecarga de operadores de comparación
        public static bool operator <(Futbolista a, Futbolista b)
        {
            return a.Goles < b.Goles;
        }

        public static bool operator >(Futbolista a, Futbolista b)
        {
            return a.Goles > b.Goles;
        }

        public static bool operator <=(Futbolista a, Futbolista b)
        {
            return a.Goles <= b.Goles;
        }

        public static bool operator >=(Futbolista a, Futbolista b)
        {
            return a.Goles >= b.Goles;
        }

        // Sobrecarga de operadores de igualdad
        public static bool operator ==(Futbolista a, Futbolista b)
        {
            return a.Goles == b.Goles;
        }

        public static bool operator !=(Futbolista a, Futbolista b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }


            return (Futbolista) obj == this;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nombre,Goles);
        }

        public override string ToString()
        {
            return Nombre+" - "+Goles;
        }

        public int CompareTo(Futbolista? other)
        {
            return Goles.CompareTo(other?.Goles);
        }
    }
}
