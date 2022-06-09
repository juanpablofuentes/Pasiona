using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosHerencia
{
    internal interface IDraw
    {
        public void Draw();
    }

    interface IFullDraw : IDraw
    {
        public void FullDraw();
    }
}
