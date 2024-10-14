using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal class Alumno:Persona
    {
        public  Alumno(String nombre): base(nombre)
        {
            
        }
        public override String saludo()
        {
            
            return "Bienvenido " + base.saludo();
        }
    }
}
