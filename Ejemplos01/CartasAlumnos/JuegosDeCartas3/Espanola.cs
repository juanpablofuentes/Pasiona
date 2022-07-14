using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    internal class Espanola : IBaraja
    {
        int[] IBaraja.numeracion()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        }

        string[] IBaraja.nombres()
        {
            return new string[] { "As", "2", "3", "4", "5", "6", "7", "Sota", "Caballo", "Rey" };
        }

        string[] IBaraja.palos()
        {
            return new string[] { "Oros", "Copas", "Espadas", "Bastos" };
        }
    }
}