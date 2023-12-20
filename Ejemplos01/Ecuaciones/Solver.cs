using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuaciones
{
    public static class Solver
    {
        public static (double? x1, double? x2) segundoGrado(double a, double b, double c)
        {
            if(a == 0 && b == 0)
            {
                return (null,null);
            }

            double discriminante = b * b - 4 * a * c;
            if (discriminante<0)
            {
                return (null, null);
            }
            return (0, 0);

        }
    }
}
