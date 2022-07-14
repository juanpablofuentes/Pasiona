using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal static class Extension {

        public static List<T> Sort<T>(this List<T> l, IComparer<T> c) {

            T [] a = l.ToArray();

            Array.Sort(a, c);

            return new List<T>(a);
        }

    }
}
