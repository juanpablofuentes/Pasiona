using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
