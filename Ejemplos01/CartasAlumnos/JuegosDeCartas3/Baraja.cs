using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    internal class Baraja
    {
        public Carta[] Cartas { get; set; }
        //private IBaraja TipoBaraja;

        public Baraja(IBaraja tipoBaraja)
        {
            int longitud = tipoBaraja.numeracion().Length * tipoBaraja.palos().Length, posicion = 0;
            Carta[] baraja = new Carta[longitud];

            foreach (string palo in tipoBaraja.palos())
            {
                for (int i = 0; i < tipoBaraja.numeracion().Length; i++)
                {
                    baraja[posicion] = new Carta(tipoBaraja.numeracion()[i], tipoBaraja.nombres()[i], palo);
                    posicion++;
                }
            }
            Cartas = baraja;
        }

        public Carta[] Mezclar()
        {
            Carta[] mezcla;
            Random rand = new Random();

            mezcla = Cartas.OrderBy(x => rand.Next()).ToArray();
            Cartas = mezcla;

            return mezcla;
        }

        public Carta DarCarta()
        {
            Carta carta;

            for (int i = 0; i < Cartas.Length; i++)
            {
                if (Cartas[i] != null)
                {
                    carta = Cartas[i];
                    Cartas[i] = null;
                    return carta;
                }
            }

            return null;
        }
    }
}
