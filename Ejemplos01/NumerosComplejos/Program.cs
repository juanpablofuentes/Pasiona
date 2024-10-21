namespace NumerosComplejos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPares = from n in numeros
                               where n % 2 == 0
                               select n;

            var ordenadosPorNombre = from p in numeros
                                     orderby p
                                     select p;



        }
    }
}