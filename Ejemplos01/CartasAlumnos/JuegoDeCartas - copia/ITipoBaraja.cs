using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    public interface ITipoBaraja
    {
        public string[] getPalos();
        public string[] getValor();
    }
}
