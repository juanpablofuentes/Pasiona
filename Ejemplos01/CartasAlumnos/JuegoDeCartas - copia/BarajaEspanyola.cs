using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class BarajaEspanyola : IValoresCartas, ITipoBaraja
    {
        string[] ITipoBaraja.getPalos()
        {
            return new string[] { "oros", "copas", "espadas", "bastos" };
        }

        string[] ITipoBaraja.getValor()
        {
            return new string[] { "A", "2", "3", "4", "5", "6", "7", "sota", "caballo", "rey" };
        }
    }
}
