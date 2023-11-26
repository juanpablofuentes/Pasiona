using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    internal class Poker : Juego
    {
        public Poker(Jugador[] jugadores)
        {
            if (jugadores.Length < 2 || jugadores.Length > 10) { throw new ArgumentException("El mus es un juego de 4 jugadores"); }

            Baraja francesa = new Baraja(new Francesa());
            francesa.Mezclar();
            Repartir(jugadores, francesa, 5);
        }


        public Jugador CartaAlta(Jugador[] jugadores)
        {
            foreach (Jugador jugador in jugadores)
            {
                Array.Sort(jugador.VerMano, (a, b) => (b.Numero - a.Numero));
            }

            List<Jugador> participantes = jugadores.ToList();
            List<int> cartas = new List<int>();

            for (int i = 0; i < 4 && participantes.Count > 1; i++)
            {
                for (int j = 0; j < participantes.Count; j++)
                {
                    cartas.Add(participantes[j].VerMano[i].Numero);
                }

                for (int n = 0; n < participantes.Count; n++)
                {
                    if (cartas[n] != cartas.Max())
                    {
                        participantes.RemoveAt(n);
                        cartas.RemoveAt(n);
                        n--;
                    }
                }

                cartas.Clear();
            }

            return participantes[0];
        }
    }
}
