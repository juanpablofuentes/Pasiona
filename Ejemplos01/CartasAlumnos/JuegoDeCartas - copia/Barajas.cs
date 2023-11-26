using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    public class Barajas
    {
        public List<Carta> Baraja { get; set; }

        private ITipoBaraja TipoBaraja;

        public Barajas(ITipoBaraja tipoBaraja)
        {
            Baraja = new List<Carta>();
            TipoBaraja = tipoBaraja;
        }
        public void Barajar()
        {
            Random rnd = new Random();
            Baraja = Baraja.OrderBy(x => rnd.Next()).ToList();
        }
        public void RellenarBaraja()
        {
            int contador = 0;
            int numero = 2;

            for (int i = 0; i < TipoBaraja.getPalos().Length; i++)
            {
                for (int j = 0; j < TipoBaraja.getValor().Length; j++)
                {
                    Carta carta = new Carta(TipoBaraja.getPalos()[i], TipoBaraja.getValor()[j], numero);
                    numero++;
                    Baraja.Add(carta);
                    contador++;
                }
                numero = 2;
            }
        }
    }
}
