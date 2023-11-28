using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegados.Numeros;

namespace Delegados
{
    public delegate double operacion(double value);
    public delegate void Imprimir(int value);
    public delegate void Empresa(string nombre);
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir delegado = ImprimirNumero;
            Empresa e = bienvenida;
            Empleado eva = new Empleado("Eva");
            eva.ejecutar(e);
            e = despedido;
            eva.ejecutar(e);
            eva.ejecutar(promocionar);
            int num = 1000;

            delegado(num);
            delegado.Invoke(num);
            Console.WriteLine("------");
            delegado = ImprimirMoneda;
            delegado(num);
            delegado.Invoke(num);
            Console.WriteLine("------");

            delegado += ImprimirNumero;
            delegado += ImprimirHexa;

            delegado(num);
            Console.WriteLine("------");

            delegado -= ImprimirNumero;
            delegado(num);
            Console.WriteLine("------");

            e = bienvenida;
            e += promocionar;

            eva.ejecutar(e);


            Numeros n = new Numeros();
            n.lista.Add(10);
            n.lista.Add(20);
            n.lista.Add(30);
            n.lista.Add(40);
            n.lista.Add(50);
            Console.WriteLine(n);
            Console.WriteLine("------");
            n.Operacion = Operaciones.cuadrado;

            n.procesar();
            Console.WriteLine(n);
            Console.WriteLine("------");
            n.Operacion = Operaciones.raiz;
            n.procesar();
            Console.WriteLine(n);
            Console.WriteLine("------");
            n.Operacion = Operaciones.doble;
            n.Operacion += Operaciones.cuadrado;
            n.procesar();
            Console.WriteLine(n);
            Console.WriteLine("------");

            operacion cuadrado = x => x * x;
            Console.WriteLine($"Cuadrado de 5: {cuadrado(5)}");  // Output: 25

            // Ejemplo 2: Función que devuelve el doble de un número
            operacion doble = x => x * 2;
            Console.WriteLine($"Doble de 8: {doble(8)}");  // Output: 16

            // Ejemplo 3: Función que calcula la raíz cuadrada de un número
            operacion raizCuadrada = x => Math.Sqrt(x);
            Console.WriteLine($"Raíz cuadrada de 9: {raizCuadrada(9)}");  // Output: 3

            // Ejemplo 4: Función que devuelve el valor absoluto de un número
            operacion valorAbsoluto = x => Math.Abs(x);
            Console.WriteLine($"Valor absoluto de -7: {valorAbsoluto(-7)}");  // Output: 7

            


        }
        public static void bienvenida(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        public static void despedido(string nombre)
        {
            Console.WriteLine(nombre + " estás despedido");
        }
         public static void promocionar(string nombre)
        {
            Console.WriteLine(nombre + " te hemos subido el sueldo");
        }
        public static void ImprimirNumero(int num)
        {
            Console.WriteLine("Numero: {0,-12:N0}", num);
        }
        public static void ImprimirNumero(double num)
        {
            Console.WriteLine("Numero: {0,-12:N0}", num);
        }
        public static void ImprimirMoneda(int money)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Moneda: {0:C} ", money);
        }

        public static void ImprimirHexa(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

    }

}
