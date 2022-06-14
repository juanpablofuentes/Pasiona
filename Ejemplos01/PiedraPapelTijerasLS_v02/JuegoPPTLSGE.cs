using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_v2
{
    class JuegoPPTLSGE : Juego
    {
        public JuegoPPTLSGE(Jugador jugador1, Jugador jugador2) : base(jugador1, jugador2)
        {
            this.jugadas = new string[] { "piedra", "papel", "tijeras", "spock", "lagarto", "jarra", "edans" };
        }

        public override string comprobar(Jugador jugador1, Jugador jugador2)
        {

            //Hago una matriz con los valores de quien gana a quien
            int[][] matriz = { new int[]  {2,4,5 }, new int[] { 0,6,3 }, 
                               new int[] { 6,1,4},  new int[] { 5,0,2}, 
                        new int[] { 1,5,3 }, new int[] { 5,1,2 },new int[]  {0,4,3 }  };

            int pos1 = Array.IndexOf(jugadas, jugador1.jugada.ToLower());
            int pos2 = Array.IndexOf(jugadas, jugador2.jugada.ToLower());
            if (matriz[pos1].Contains(pos2)) return jugador1.Nombre;
            if (matriz[pos2].Contains(pos1)) return jugador2.Nombre;
            return "Empate";
        }
    }
}
