using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class Jugador
    {
        public List<Carta> CartasJugador { get; set; }

        public string Nombre { get; set; }

        public Tuple<int, int> ?CombinacionMano {get; set; }
        //el vacio existe para poder clonarlo
        public Jugador()
        {
        }
        public Jugador(string nombre, int numCartas)
        {
            Nombre = nombre;
            CartasJugador = new List<Carta>(numCartas);
        }

        public override string ToString()
        {
            string cartas = "";

            for (int i = 0; i < CartasJugador.Count; i++)
            {
                cartas += CartasJugador[i] + " ";
            }

            return cartas;
        }
    }
}
