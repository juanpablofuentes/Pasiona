using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    abstract class Juego
    {  
        public List<Jugador> ListaJugadores { get; set; }
        public Juego(int numeroJugadores)
        {
           ListaJugadores = new List<Jugador>();
        }
        public abstract void AddJugador(Jugador jugador);
        public abstract void Repartir();

    }
}
