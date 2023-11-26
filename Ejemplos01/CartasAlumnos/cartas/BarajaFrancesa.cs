using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618

namespace cartas {
    internal class BarajaFrancesa : IBaraja {

        public string [] Palos () => new string [] { "treboles", "diamantes", "corazones", "picas" };
        public string [] Valores () => new string [] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k", "as"};

    }
}
