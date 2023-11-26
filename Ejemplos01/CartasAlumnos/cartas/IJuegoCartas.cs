using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal interface IJuegoCartas {

        public Baraja Baraja();

        public int NumeroMano ();

        public bool FinalPartida ();

        public IJugador [] Jugadores ();

        public void PasarRonda ();

        public void Jugador (IJugador jugador);

        public IJugador[] JugadorGanador ();

        public void repartir () {
            foreach (IJugador jugador in Jugadores()) {
                jugador.Mano = Baraja().darMano(this);
                jugador.mostrarMano();
            }
        }

    }
}
