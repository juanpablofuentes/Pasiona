using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCEjemplo
{
    internal class SaludoConsola : ISaludo
    {
        public void saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre} qué tal estás");
        }
    }
}
