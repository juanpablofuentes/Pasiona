using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    internal class Campeonato<T>
    {
        private Dictionary<T, bool> jugadores = new Dictionary<T, bool>();
        private List<T> torneo = new List<T>();
        public void Add(T elemento)
        {
            jugadores[elemento] = false;
        }

        public void gana(T elemento)
        {
            int pos = torneo.IndexOf(elemento);
            if (pos == -1)
            {
                throw new Exception("Elemento no encontrado");
            }
            else
            {
                int pos2;
                if (pos % 2 == 0)
                {
                    pos2 = pos + 1;
                }
                else
                {
                    pos2 = pos - 1;
                }
                jugadores[torneo[pos2]] = false;
                jugadores[torneo[pos]] = true;
            }
        }
        public void SiguienteRonda()
        {
            if (jugadores.Count == 1)
            {
                throw new Exception("Ya se han acabado las rondas");
            }
            if (jugadores.Values.Count(x => x) != jugadores.Count / 2)
            {
                throw new Exception("Faltan ganadores");
            }
            foreach (T el in torneo)
            {
                if (jugadores[el])
                {
                    jugadores[el] = false;
                }
                else
                {
                    jugadores.Remove(el);
                }
            }
            torneo = jugadores.Keys.ToList();
        }
        public void Organizar()
        {
            if (jugadores.Count == Math.Pow(Math.Round(Math.Log2(jugadores.Count)), 2))
            {
                torneo = jugadores.Keys.ToList();
                torneo.Shuffle();
                for (int i = 0; i < jugadores.Count; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine("----------");
                    }
                    Console.WriteLine(torneo[i]);
                }
            }
            else
            {
                throw new Exception("Jugadores no potencias de 2");
            }
        }

        public override string ToString()
        {
            return String.Join(",", jugadores);
        }
    }

    static class Extension
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
