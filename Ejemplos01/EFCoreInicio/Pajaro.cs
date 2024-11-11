using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInicio
{
    internal class Pajaro
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public string Descripcion { get;set; }

        public Pajaro(String nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre+" -"+Descripcion;
        }
    }
}
