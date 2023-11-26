using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cartas {
    internal class CartaEspanola : Carta {

        public CartaEspanola (string valor, string palo) : base(valor, palo, new BarajaEspanola()){

        }
    }
}
