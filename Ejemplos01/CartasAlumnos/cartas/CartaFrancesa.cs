using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class CartaFrancesa : Carta{

        public CartaFrancesa (string valor, string carta) : base(valor, carta, new BarajaFrancesa()) {

        }

    }
}
