using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    internal class Comparador : IComparer<Jugador>
    {
        Func<int[], int> ComparadorFunc;

        public Comparador(Func<int[], int> comparadorFunc)
        {
            ComparadorFunc = comparadorFunc;
        }

        public int Compare(Jugador? x, Jugador? y)
        {

            int[] cartas1 = x.Mano.Select(f => f.Valor).ToArray();
            int[] cartas2 = y.Mano.Select(f => f.Valor).ToArray();
            Array.Sort(cartas1);
            Array.Sort(cartas2);
            return ComparadorFunc(cartas2).CompareTo(ComparadorFunc(cartas1));
        }

      
    }
}
