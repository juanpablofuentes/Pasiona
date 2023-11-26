using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class Consola : IOutGanador, IGetJugadores {
        public virtual void mostrarGanador (IJuegoCartas juego) => Console.WriteLine("Ganador: " + juego.JugadorGanador() [0]);
        public IJugador [] PedirJugadores (int min, int max) {

            List<IJugador> jugadores = new List<IJugador> ();

            String nombreJugador = " ";

            for (int i = 0; (i <= min || nombreJugador != "") && i < max; i++) {

                Console.Write($"Nombre jugador {i+1}: ");

                nombreJugador = Console.ReadLine();

                nombreJugador = nombreJugador.Trim();

                if (nombreJugador != "") jugadores.Add(new Jugador(nombreJugador));
                else if (i < min) i--;
            }

            return jugadores.ToArray();

        }
    }
}
