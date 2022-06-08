using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    internal abstract class Figura
    {
        public string Nombre { get; set; }

        public abstract float area();
    }

    class Hexagono : Figura, IDraw
    {

    }

    class Pentagono : Figura, IFullDraw
    {

    }
}
