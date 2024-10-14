using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    public class Empleado :Persona
    {
        public int Sueldo { get; set; }
        public Empleado(String nombre)
        {
            Nombre=nombre;
        }
        public override String  saludo()
        {
            return "¡Que pasa " + Nombre;
        }
    }
}
