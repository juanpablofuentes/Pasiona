using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class Jugador : IJugador {
        public List<Carta> Mano { get; set; }
        public string Nombre { get; set; }

        public Jugador (string nombre) {
            Nombre = nombre;
        }

        public void mostrarMano () {

            Console.WriteLine($"Jugador {Nombre}, tu mano es:");

            foreach (Carta carta in Mano)
                Console.Write(carta + (carta == Mano [^1] ? "\n" : " "));

        }
    }
}
