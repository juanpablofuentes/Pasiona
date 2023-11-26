using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class ExtensionCadenas
    {
        public static string AppendText(this string input, string textToAppend)
        {
            // Modificar el propio valor de la cadena
            return input + textToAppend;
        }
        public static void EliminarPares(this int[] array)
        {
            int indice = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
            
        }
    }
}
