using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_v3
{
    class ParesNones : ILogica
    {
        private string[] _validas = { "0","1","2","3","4","5" };
        public ParesNones()
        {

        }
        public int comprobar(string jugada1, string jugada2)
        {
            if (jugada1 == "Azul") return 1;
            if (jugada2 == "Azul") return 2;
            return 0;
        }

        public string[] validas()
        {
            return this._validas;
        }
    }
}
