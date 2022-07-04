using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaAlumnos
{
    internal class Alumno
    {
        public String Nombre { get; set; }
        public int Nota { get; set; }

        public Alumno(string nombre, int nota)
        {
            Nombre = nombre;
            Nota = nota;
        }
        public override string ToString()
        {
            return Nombre+" "+Nota;
        }
    }
}
