using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCEjemplo
{
    internal class Ruleta
    {
        private IGetNumber _getnumero;
        int numero;
        public Ruleta(IGetNumber getnumero)
        {
            _getnumero = getnumero;
        }
        public void tirada()
        {
            numero = _getnumero.GetNumber();
            Console.WriteLine(numero);
        }
        public override string ToString()
        {
            return numero.ToString();
        }
    }
}
