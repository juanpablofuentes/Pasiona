using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BotonTarea
{
    internal static class Utils
    {
        public static int[] crear(int tam)
        {
            int[] result = new int[tam];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (new Random()).Next(100000);
            }
            return result;
        }

        public static int[] ordenar(int[] numeros, TextBox t)
        {
            int[] ordenado = new int[numeros.Length];
            numeros.CopyTo(ordenado, 0);
            for (int i = 0; i < ordenado.Length; i++)
            {
                if (i % 1000 == 0)
                {
                    t.Invoke((MethodInvoker)delegate
                     {
                         t.Text += i+", ";
                     });
                }
                for (int j = 1; j < ordenado.Length; j++)
                {
                    if (ordenado[j - 1] > ordenado[j])
                    {
                        (ordenado[j - 1], ordenado[j]) = (ordenado[j], ordenado[j - 1]);
                    }
                }
            }
            return ordenado;
        }

        public static int[] ordenar(int[] numeros)
        {
            int[] ordenado = new int[numeros.Length];
            numeros.CopyTo(ordenado, 0);
            for (int i = 0; i < ordenado.Length; i++)
            {
                for (int j = 1; j < ordenado.Length; j++)
                {
                    if (ordenado[j - 1] > ordenado[j])
                    {
                        (ordenado[j - 1], ordenado[j]) = (ordenado[j], ordenado[j - 1]);
                    }
                }
            }
            return ordenado;
        }
        public static int[] filtrar(int[] numeros, Predicate<int> operacion)
        {
            int[] filtrado = new int[numeros.Length];

            int cont = 0;
            for (int i = 0; i < numeros.Length; i++)
            {

                if (operacion(numeros[i]))
                {
                    filtrado[cont] = numeros[i];
                    cont++;
                    
                }

            }
            Array.Resize(ref filtrado, cont);
            Thread.Sleep(5000);
            return filtrado;
        }
        public static void manejarPila(string nombre, Queue<int> cola, TextBox t) {

            while (cola.Count > 0)
            {
                Random r = new Random();
                if (r.Next(3) > 1)
                {
                    cola.Enqueue(r.Next(3000));
                }
                else
                {
                    if (cola.Count>0) { 
                    t.Invoke((MethodInvoker)delegate
                    {
                        t.Text += nombre+"-"+cola.Dequeue() + "\r\n";
                    });
                    }
                }
                Thread.Sleep(1000);
            }
        
        }

        public static void crearElementos(string nombre, List<Elemento> elementos)
        {
            TextBox salida = elementos[0].txtMostrar;

            while (elementos.Count > 0)
            {
                
                List<Elemento> lista = elementos.Where(x => x.Estado == 0).ToList();
                foreach (Elemento elemento in lista)
                {
                    Thread.Sleep(1000);
                    elemento.Elementos = Utils.crear(10000);
                    elemento.Estado = 1;
                    elemento.txtMostrar?.Invoke((MethodInvoker)delegate
                    {
                        elemento.txtMostrar.Text += nombre + " - "+elemento.Numero+" \r\n";
                    });
                }
               
            }
            salida?.Invoke((MethodInvoker)delegate
            {
                salida.Text += nombre + " finalizada \r\n";
            });

        }
        public static void procesarElementos(string nombre, List<Elemento> elementos)
        {
            TextBox salida = elementos[0].txtMostrar;
            while (elementos.Count > 0)
            {

                List<Elemento> lista = elementos.Where(x => x.Estado == 1).ToList();
                foreach (Elemento elemento in lista)
                {
                    Thread.Sleep(1000);
                    elemento.Elementos = Utils.ordenar(elemento.Elementos);
                    elemento.Estado = 2;
                    elemento.txtMostrar?.Invoke((MethodInvoker)delegate
                    {
                        elemento.txtMostrar.Text += nombre + " - " + elemento.Numero + " \r\n";
                    });
                }

            }
            salida?.Invoke((MethodInvoker)delegate
            {
                salida.Text +=  nombre + " finalizada \r\n";
            });

        }

        public static void liberarElementos(string nombre, List<Elemento> elementos)
        {
            TextBox salida = elementos[0].txtMostrar;
            while (elementos.Count > 0)
            {

                List<Elemento> lista = elementos.Where(x => x.Estado == 2).ToList();
                foreach (Elemento elemento in lista)
                {
                    Thread.Sleep(2000);
                    elemento.txtMostrar?.Invoke((MethodInvoker)delegate
                    {
                        elemento.txtMostrar.Text += nombre + " - " + elemento.Numero + " \r\n";
                    });
                    elementos.Remove(elemento);
                }

            }
            salida?.Invoke((MethodInvoker)delegate
            {
                salida.Text += nombre + " finalizada \r\n";
            });

        }
    }
}
