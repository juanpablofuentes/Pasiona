using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas_2
{
    internal class Carta
    {
        public string palo;
        public int valor;

        public Carta(int valor, string palo)
        {
            this.palo = palo;
            this.valor = valor;
        }

        public override string ToString()
        {
            return $"{valor} de {palo}";

        }
    }
}
