using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace EjemplosSimplesC
{
    internal class Program
    {
        // Clase curso
        // addAlumno

        static void Main(string[] args)
        {
            Dictionary<String,String> keyValuePairs = new Dictionary<String,String>(); 
            
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            // Obtener todos los números pares
            var numerosPares = from numero in numeros
                               where numero % 2 == 0
                               select numero;

            // Obtener la suma de todos los números
            var total = numeros.Sum();

            // Obtener el número máximo
            var maximo = numeros.Max();

            // Obtener el número mínimo
            var minimo = numeros.Min();

            // Obtener el promedio de los números
            var promedio = numeros.Average();
            
            var dobles = numeros.Select(x => x * 2);
            var dobles2 = numeros.Select(doble);
            var pares =numeros.Where(x=>x%2==0);

            Func< String, int,int> suma = (cad,a) =>
            {
                return 42;
            };
            Console.WriteLine(suma(3, 4)); // Salida: 7
            Program.suma(3, 4);

            Action<int,int> imprimirCuadrado = (n,m) =>
            {
                int cuadrado = n * n;
                Console.WriteLine($"El cuadrado de {n} es {cuadrado}");
            };
        }
        static int suma(int a, int b)
        {
            return a + b;
        }
        static int doble(int num)
        {
            return num*2;
        }
       public static int total(int[] numeros)
        {
            int res = 0;
            foreach(int num in numeros)
            {
                res += num;
            }
            return res;
        }
    }
}