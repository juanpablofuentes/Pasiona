using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class JuegoCartas {

        private IJuegoCartas _juego;
        private IOutGanador _outGanador;

        public JuegoCartas (IJuegoCartas juego, IOutGanador outGanador) {
            _juego = juego;
            _outGanador = outGanador;
        }

        public JuegoCartas (IJuegoCartas juego) : this(juego, new Consola()) {

        }

        public void Jugar () {

            _juego.repartir();

            while (!_juego.FinalPartida()) {

                foreach (IJugador juagador in _juego.Jugadores())
                    _juego.Jugador(juagador);

                _juego.PasarRonda();
            }

            _outGanador.mostrarGanador(_juego);

        }
    }
}
