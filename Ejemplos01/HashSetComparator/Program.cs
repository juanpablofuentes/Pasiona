using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace HashSetComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<parInt> parInts = new HashSet<parInt>(new parIntComparador()); //no sé como indicar que utilice el comparador de valores en vez de comparar los "pares" en sí
            int[] v1 = { 1, 2, 3, 4, 5, 6, 4, 8, 5 };
            int[] v2 = { 1, 6, 5, 4, 3, 2, 4, 0, 3 };
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] + v2[i] == 8)
                {
                    parInts.Add(new parInt(v1[i], v2[i]));
                }
            }
            foreach (parInt par in parInts)
            {
                Console.WriteLine($"{par.V1} + {par.V2} = 8");
            }
        }
    }
    public class parInt
    {
        public int V1 { get; set; }
        public int V2 { get; set; }
        public parInt(int v1, int v2)
        {
            V1 = v1; V2 = v2;
        }
        public bool Equals(parInt? x, parInt? y)
        {
            if (x == null || y == null)
                return false;
            return x.V1 == y.V1 || x.V1 == y.V2;
        }
    }

    public class parIntComparador : IEqualityComparer<parInt>
    {
        public bool Equals(parInt? x, parInt? y)
        {
            if (x == null || y == null)
                return false;
            return x.V1 == y.V1 || x.V1 == y.V2;
        }

        public int GetHashCode([DisallowNull] parInt obj)
        {
            if (obj.V1 > obj.V2)
                return obj.V1 * 10 + obj.V2;
            return obj.V2 * 10 + obj.V1;
        }
    }
}