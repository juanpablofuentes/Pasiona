using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 128; i < 256; i++)
            {
                Console.WriteLine(i + " " + (char)i);
            }
        }
    }
}
