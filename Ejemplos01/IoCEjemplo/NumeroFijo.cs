using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCEjemplo
{
    internal class NumeroFijo : IGetNumber
    {
        public int GetNumber()
        {
            return 27;
        }
    }
}
