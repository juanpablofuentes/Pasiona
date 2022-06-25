using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Clase
    {

        public List<String> Alumnos = new List<string>();
        public String Nombre { get; set; }

        public Clase(string nombre)
        {
            Nombre = nombre;
        }

        public String this[int i]
        {
            get { return Alumnos[i]; }
            set
            {
                if (i >= Alumnos.Count)
                {
                    Alumnos.Add(value);
                }
                else
                {
                    Alumnos[i] = value;
                }
            }
        }

        public int this[String nombre]
        {
            get { return Alumnos.IndexOf(nombre);}
        }
      
        public override string ToString()
        {
            return String.Join(",",Alumnos);
        }

    }
}
