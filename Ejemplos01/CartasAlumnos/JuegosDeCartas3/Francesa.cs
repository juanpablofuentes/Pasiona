using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    internal class Francesa : IBaraja
    {
        int[] IBaraja.numeracion()
        {
            return new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        }

        string[] IBaraja.nombres()
        {
            return new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "As" };
        }

        string[] IBaraja.palos()
        {
            return new string[] { "Corazones", "Diamantes", "Tréboles", "Picas" };
        }
    }
}
