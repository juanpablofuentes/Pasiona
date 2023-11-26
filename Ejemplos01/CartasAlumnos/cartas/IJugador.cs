using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal interface IJugador {

        public List<Carta> Mano { get; set; }

        public string Nombre { get; set; }

        public void mostrarMano ();

    }
}
