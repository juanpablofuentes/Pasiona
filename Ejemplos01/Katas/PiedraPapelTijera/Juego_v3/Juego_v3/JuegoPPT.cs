﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_v3
{
    class JuegoPPT: ILogica
    {
        private string[] jugadas = { "piedra", "papel", "tijeras" };

        public int comprobar(string jugada1, string jugada2)
        {
            int pos1 = Array.IndexOf(jugadas, jugada1.ToLower());
            int pos2 = Array.IndexOf(jugadas, jugada2.ToLower());
            if ((pos1 + 1) % 3 == pos2) return 2;
            if ((pos2 + 1) % 3 == pos1) return 1;
            return 0;
        }

        string[] ILogica.validas()
        {
            return this.jugadas;
        }
    }
}
