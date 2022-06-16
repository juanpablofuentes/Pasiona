using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_v3
{
    class JuegoPPTLSGE : ILogica
    {
        private string[] jugadas = new string[] { "piedra", "papel", "tijeras", "spock", "lagarto", "jarra", "edans" };

        public int comprobar(string jugada1, string jugada2)
        {
            int[][] matriz = { new int[]  {2,4,5 }, new int[] { 0,6,3 },
                               new int[] { 6,1,4},  new int[] { 5,0,2},
                        new int[] { 1,5,3 }, new int[] { 5,1,2 },new int[]  {0,4,3 }  };

            int pos1 = Array.IndexOf(jugadas, jugada1.ToLower());
            int pos2 = Array.IndexOf(jugadas, jugada2.ToLower());
            if (matriz[pos1].Contains(pos2)) return 1;
            if (matriz[pos2].Contains(pos1)) return 2;
            return 0;
        }

        string[] ILogica.validas()
        {
            return this.jugadas;
        }
    }
    
    
}
