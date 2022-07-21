using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Alumno
    {
        public Alumno(string nombre, string dNI, int nota)
        {
            Nombre = nombre;
            DNI = dNI;
            Nota = nota;
        }

        public String Nombre { get; set; }
        public String DNI { get; set; }
        public int Nota { get; set; }

        public bool Aprobado() { return Nota>=5; }
        public override string ToString()
        {
            return Nombre+ ", "+DNI+", "+Nota;
        }
    }
}
