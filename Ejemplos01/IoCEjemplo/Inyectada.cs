using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCEjemplo
{
    internal class Inyectada
    {
        private readonly ISaludo _saludo;

        public Inyectada(ISaludo saludo)
        {
            _saludo = saludo;
        }
        public void saludar(string nombre)
        {
            _saludo.saludar(nombre);
        }
    }
}
