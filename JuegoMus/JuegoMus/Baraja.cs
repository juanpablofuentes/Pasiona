using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    public class Baraja
    {
        public List<Carta> Mazo { get; set; }
        private ITipoBaraja TipoBaraja;

        public Baraja(ITipoBaraja tipoBaraja)
        {
            Mazo= new List<Carta>();
            TipoBaraja= tipoBaraja;
        }

        public void CrearMazo()
        {
            foreach(string palo in TipoBaraja.getPalos())
            {
                foreach(int valor in TipoBaraja.getRango())
                {
                    Mazo.Add(new Carta(palo, valor));
                }
            }
        }

        public void Barajar()
        {
            Mazo.Shuffle();
        }

        public Carta Repartir()
        {
            return Mazo.Pop();
        }

        public override string ToString()
        {
            return String.Join(",",Mazo);
        }
    }
}
