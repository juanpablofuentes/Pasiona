using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class ConsolaMus : Consola{

        public override void mostrarGanador (IJuegoCartas juego) {

            IJugador [] ganadores = juego.JugadorGanador();

            Console.WriteLine("Ganador Grande: " + ganadores [0].Nombre);
            Console.WriteLine("Ganador Chica: " + ganadores [1].Nombre);
            Console.WriteLine("Ganador Pares: " + ganadores [2].Nombre);
            Console.WriteLine("Ganador Juego: " + ganadores [3].Nombre);


        }

    }
}
