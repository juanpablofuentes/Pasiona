using System;

namespace EjemplosFuncActionPredicat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Función que suma dos números:



            Func<int, int, int> sumar = (a, b) => a + b;
            int resultadoSuma = sumar(3, 4);
            Console.WriteLine(resultadoSuma);  // Output: 7

            // Función que concatena dos cadenas:



            Func<string, string, string> concatenar = (s1, s2) => s1 + s2;
            string resultadoConcatenacion = concatenar("Hola, ", "mundo!");
            Console.WriteLine(resultadoConcatenacion);  // Output: Hola, mundo!


            // Acción que imprime un mensaje:



            Action<string> imprimirMensaje = mensaje => Console.WriteLine(mensaje);
            imprimirMensaje("Hola desde la acción.");

            //Acción que realiza múltiples operaciones:



            Action<int, int> operaciones = (a, b) =>
            {
                Console.WriteLine($"Suma: {a + b}");
                Console.WriteLine($"Resta: {a - b}");
                Console.WriteLine($"Multiplicación: {a * b}");
            };
            operaciones(5, 3);



             
            // Predicado que verifica si un número es par:



            Predicate<int> esPar = num => num % 2 == 0;
            bool resultadoEsPar = esPar(6);
            Console.WriteLine(resultadoEsPar);  // Output: True

            // Predicado que verifica si una cadena contiene la letra 'a':



            Predicate<string> contieneLetraA = cadena => cadena.Contains("a");
            bool resultadoContieneA = contieneLetraA("Ejemplo");
            Console.WriteLine(resultadoContieneA);  // Output: True


            //Función como parámetro:



            void EjecutarOperacion(Func<int, int, int> operacion, int a, int b)
            {
                int resultado = operacion(a, b);
                Console.WriteLine($"Resultado de la operación: {resultado}");
            }

            EjecutarOperacion((x, y) => x * y, 4, 5);

            // Acción como parámetro:



            void RealizarAccion(Action<string> accion, string mensaje)
            {
                accion(mensaje);
            }

            RealizarAccion(m => Console.WriteLine($"Mensaje: {m}"), "Hola, mundo!");

            // Predicado como parámetro:



            bool VerificarPredicado(Predicate<int> predicado, int numero)
            {
                return predicado(numero);
            }

            bool esNegativo = VerificarPredicado(n => n < 0, -7);
            Console.WriteLine($"Es negativo: {esNegativo}");  // Output: True

            //Currificación

            // Función normal
            Func<int, int, int> suma = (a, b) => a + b;

            // Funciones parcialmente aplicadas (currificadas)
            Func<int, Func<int, int>> sumaParcial = (a => b => suma(a, b));

            // Utilizando funciones parcialmente aplicadas
            int resultadoSuma1 = sumaParcial(3)(4);//sumaParcial(3)= b => suma(3, b)
            int resultadoSuma2 = sumaParcial(5)(7);

            Console.WriteLine(resultadoSuma1);  // Output: 7
            Console.WriteLine(resultadoSuma2);  // Output: 12


            // Func<int, Func<int, int>> que multiplica dos números y devuelve el resultado
            Func<int, Func<int, int>> multiplicar = a => b => a * b;
            Console.WriteLine(multiplicar(2)(3)); // Output: 6



            Func<int, int> multiplicarPorDos = multiplicar(2); // b=>2*b
            Func<int, int> multiplicarPorTres = multiplicar(3); // b=>3*b

            Console.WriteLine(multiplicarPorDos(3)); // Output: 6
            Console.WriteLine(multiplicarPorTres(4)); // Output: 12

            Func<double, Func<double, double>> iva = a => b => a * b;

            Console.WriteLine(iva(.21)(1000));

            Func<double, double> iva21 = iva(.21);
            Console.WriteLine(iva21(1000));

        }
    }
}