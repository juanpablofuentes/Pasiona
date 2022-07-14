using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal interface IPreparacion
    {
        //hacer sobrecarga con el mus
        public static void PedirJugador(JuegoPoker juegoPoker, int numeroJugadores) { }

        public static void Inicializar() { }
    }
}
