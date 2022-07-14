using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    class Juego
    {
        public void Repartir(Jugador[] jugadores, Baraja baraja, int cartasJug)
        {
            Carta carta;

            for (int i = 0; i < cartasJug; i++)
            {
                for (int j = 0; j < jugadores.Length; j++)
                {
                    carta = baraja.DarCarta();
                    jugadores[j].Mano(carta);
                }
            }

            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine(jugador);
                Console.WriteLine("---------------------------");
                foreach (Carta c in jugador.VerMano)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
            }
        }
    }
}
