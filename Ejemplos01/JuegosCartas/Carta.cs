using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    public  class Carta
    {
        public Carta(string palo, int valor)
        {
            Palo = palo;
            Valor = valor;
        }

        public string Palo { get; set; }
        public int Valor { get; set; }

        public override string ToString() => Valor + " de " + Palo;
        
    }
}
