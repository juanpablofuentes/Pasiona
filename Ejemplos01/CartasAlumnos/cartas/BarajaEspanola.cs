using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618

namespace cartas {
    internal class BarajaEspanola : IBaraja {

        public string [] Palos () => new string [] { "oros", "copas", "espadas", "bastos" };
        public string [] Valores () => new string [] { "as", "2", "3", "4", "5", "6", "7", "sota", "caballo", "rey" };

    }
}
