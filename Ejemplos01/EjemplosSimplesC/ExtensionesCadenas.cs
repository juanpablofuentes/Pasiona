using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal static class ExtensionesCadenas
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // ToTitle hola que tal -> Hola Que Tal
        public static string ToTitle(this string str)
        {
            String[] palabras = str.Split(" ");
            var totitle = palabras.Select(x => x.Substring(0, 1).ToUpper() + x.Substring(1).ToLower());
            return String.Join(" ", totitle);

        }
        public static String toTitle(String x)
        {
            return x.Substring(0, 1).ToUpper() + x.Substring(1).ToLower();
        }
    }
}
