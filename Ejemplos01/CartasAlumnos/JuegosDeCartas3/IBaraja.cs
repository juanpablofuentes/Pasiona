using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    public interface IBaraja
    {
        public int[] numeracion();
        public string[] palos();
        public string[] nombres();
    }
}
