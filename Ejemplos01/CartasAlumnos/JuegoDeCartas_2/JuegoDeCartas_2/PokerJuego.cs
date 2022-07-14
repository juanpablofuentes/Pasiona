using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas_2
{
    internal class PokerJuego : IJuego
    {
        private List<Jugador> jugadorList;
        public Baraja Baraja { get; set; }
        private string[] palos = { "DIAMANTES", "TRÉBOLES", "CORAZONES", "PICAS" };
        private int[] valores = {  1,2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13 };
     
        public PokerJuego(List<Jugador> listaJugadores)
        {
            jugadorList = listaJugadores; 
            crearPartida();
            asignarCartas();
        }

        public void crearPartida()
        {
            Baraja = new Baraja(palos, valores);

        }
        public void asignarCartas()
        {
            foreach (Jugador jugador in jugadorList)
            {
                jugador.MisCartas1 = Baraja.repartirCartas(10);
            }
        }
    }
}
