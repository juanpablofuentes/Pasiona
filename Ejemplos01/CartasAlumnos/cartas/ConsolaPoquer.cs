using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class ConsolaPoquer : Consola{

        public override void mostrarGanador (IJuegoCartas _juego) {

            Poquer juego = (Poquer) _juego;

            IJugador ganador = juego.JugadorGanador() [0];

            Console.WriteLine($"El ganador de la partida es el jugador {ganador.Nombre} con un {juego.nombreJugada(juego.valorJugada(ganador.Mano))}");

        }

    }
}
