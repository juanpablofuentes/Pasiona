using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCEjemplo
{
    internal class SaludoFichero : ISaludo
    {
        public void saludar(string nombre)
        {
            using(StreamWriter sw = new StreamWriter("saludo.txt"))
            {
                sw.WriteLine($"Hola {nombre} qué tal estás");
            }
        }
    }
}
