using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    public class Carta
    {
        public Carta carta;

        public string Valor { get; set; }
        public string Palo { get; set; }

        public int Numero { get; set; }

        public Carta()
        {

        }
        public Carta(string palo, string valor)
        {
            Palo = palo;
            Valor = valor;
          
        }

        public Carta(string palo, string valor, int numero)
        {
            Palo = palo;
            Valor = valor;
            Numero = numero;

        }

        public Carta(Carta carta)
        {
            this.carta = carta;
        }

        public override string ToString()
        {
            return Valor + " " + Palo;
        }
    }
}
