using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class Baraja {

        private IBaraja _tipoBaraja;

        private List<Carta> _baraja;

        public Baraja(IBaraja tipoBaraja) {
            _tipoBaraja = tipoBaraja;
            generaBaraja();
        }

        public string [] Valores () =>  _tipoBaraja.Valores();
        public string [] palos () => _tipoBaraja.Palos();


        private void generaBaraja () {

            _baraja = new List<Carta>();

            string [] valores = _tipoBaraja.Valores();
            string [] palos = _tipoBaraja.Palos();

            for (int i = 0; i < valores.Length; i++)
                for(int j = 0; j < palos.Length; j++)
                    _baraja.Add(new Carta(valores [i], palos [j], _tipoBaraja));
        }

        public Carta darCarta () {
              
            int indexCarta = new Random().Next(0, _baraja.Count());

            Carta carta = _baraja.ElementAt(indexCarta);

            _baraja.RemoveAt(indexCarta);

            return carta;

        }

        public List<Carta> darMano (IJuegoCartas juego, List<Carta> ?mano = null) {

            mano = mano ?? new ();

            for (int i = mano.Count; i < juego.NumeroMano(); i++) {
                mano.Add(darCarta ());
            }

            return mano;
        
        }

        public bool Contains (Carta carta) {
            return _baraja.Contains(carta);
        }

    }
}
