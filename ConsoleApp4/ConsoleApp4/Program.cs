using System;
using System.Threading;

namespace ConsoleApp4
{
    internal class Program
    {


        static void Main()
        {

          Persona persona = new Persona();
            Persona persona2 = new Persona();
            persona.pepe = 2;
            persona2.pepe = 3;
            List<Persona> list = new List<Persona>();
            list.Add(persona2);
            list.Add(persona);
            Console.WriteLine(String.Join(",",list));
            list.Sort();
            Console.WriteLine(String.Join(",",list));

        }
        public static (int min, int max) GetMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return (min, max);
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0) { return a; } else { return b; }
        }
    }
}