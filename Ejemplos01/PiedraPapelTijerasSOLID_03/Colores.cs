using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_v3
{
    class Colores: ILogica
    {
        private string[] jugadas = { "azul", "verde", "rojo" };

        public int comprobar(string jugada1, string jugada2)
        {
            if (jugada1 == "azul") return 1;
            if (jugada2 == "azul") return 2;

            return 0;
        }

        string[] ILogica.validas()
        {
            return this.jugadas;
        }
    }
}
