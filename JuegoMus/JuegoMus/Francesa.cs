using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    internal class Francesa : ITipoBaraja
    {
        string[] ITipoBaraja.getPalos()
        {
            return new string[] { "Picas", "Diamantes", "Tréboles", "Corazones" };
        }

        int[] ITipoBaraja.getRango()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        }
    }
}
