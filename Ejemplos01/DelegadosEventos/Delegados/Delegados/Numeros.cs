using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Numeros
    {
        public List<double> lista = new List<double>();
        public delegate double operacion(double value);
        public operacion Operacion { get; set; }
        public void procesar()
        {
            for(int i = 0; i < lista.Count; i++)
            {
                lista[i] = Operacion(lista[i]);
            }
        }

        public override string ToString()
        {
            return String.Join(",", lista);
        }
    }
}
