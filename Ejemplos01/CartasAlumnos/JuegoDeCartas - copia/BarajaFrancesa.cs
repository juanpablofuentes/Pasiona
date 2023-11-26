using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class BarajaFrancesa : IValoresCartas, ITipoBaraja
    {
        string[] ITipoBaraja.getPalos()
        {
            return new string[] { "corazones", "diamantes", "trébol", "picas" };
        }

        string[] ITipoBaraja.getValor()
        {
            return new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        }
    }
}
