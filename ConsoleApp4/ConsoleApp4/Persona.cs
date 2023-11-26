using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Persona: IComparable<Persona>
    {
        public int pepe;

        public int CompareTo(Persona? other)
        {
            return pepe.CompareTo(other.pepe);
        }
        public override string ToString()
        {
            return pepe.ToString();
        }
        public string saludo()
        {
            HashCode.Combine(1, 2, 3);
            return "hola";
        }
        
    }
    internal class pepe : Persona
    {

        public  string saludo()
        {
            return "ww";
        }
        public override string ToString()
        {
            return "ww";
        }
      
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
