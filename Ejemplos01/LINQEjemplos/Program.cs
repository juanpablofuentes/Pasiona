namespace LINQEjemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 30, 4, 50, 6, 7, 8, 9, 10 };

            var numerosPares = from n in numeros // los elementos y de donde los obtengo
                               where n % 2 == 0 // Aplicando una función LINQ
                               select n;        // Proyección, que es lo que selecciono
            
            Console.WriteLine(String.Join(",",numerosPares));

            var ordenados = from n in numeros // los elementos y de donde los obtengo
                               orderby n // Aplicando una función LINQ
                               select n;

            Console.WriteLine(String.Join(",", ordenados));

            var agrupados = from n in numeros
                            group n by n%2==0 into g
                            select g;
            foreach(var g in agrupados)
            {
                Console.WriteLine(g.Key);
                Console.WriteLine(String.Join(",", g));
            }
        }
    }
}