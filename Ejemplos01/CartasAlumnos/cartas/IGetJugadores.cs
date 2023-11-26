using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal interface IGetJugadores {

        public IJugador[] PedirJugadores (int min, int max);

    }
}
