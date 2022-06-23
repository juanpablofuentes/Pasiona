using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    internal class Espanyola : ITipoBaraja
    {
        string[] ITipoBaraja.getPalos()
        {
            return new string[]  { "Oros", "Copas","Espadas", "Bastos"};
        }

        int[] ITipoBaraja.getRango()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        }
    }
}
