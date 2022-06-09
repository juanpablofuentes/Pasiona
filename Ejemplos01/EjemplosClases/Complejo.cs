using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosClases
{
    internal class Complejo
    {
        public float real { get; set; }
        public float imaginaria { get; set; }

        public float absoluto { get { return (float)Math.Sqrt(real*real+imaginaria*imaginaria); } }
        public override string ToString()=>$"{real} + {imaginaria}i";
        
        public override bool Equals(object? obj)=>this.ToString()==obj?.ToString();

        public static bool operator ==(Complejo Left, Complejo Right) => Left.Equals(Right);
        public static bool operator ==(Complejo Left, float Right) => Left.absoluto==Right;
        public static bool operator !=(Complejo Left, Complejo Right) => !Left.Equals(Right);
        public static bool operator !=(Complejo Left, float Right) => Left.absoluto != Right;
        public override int GetHashCode()=>this.ToString().GetHashCode();
        
    }
}
