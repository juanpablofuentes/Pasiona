using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; }
        public string Texto { get; set; }

        public Carta(int numero, string texto, string palo)
        {
            Numero = numero;
            Palo = palo;
            Texto = texto;
        }

        public override string ToString()
        {
            return $"{Texto} de {Palo}";
        }
    }
}