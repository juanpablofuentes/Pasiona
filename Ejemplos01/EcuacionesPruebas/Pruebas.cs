using Ecuaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EcuacionesPruebas
{
    public class Pruebas
    {
        [Fact]
        public void individuales()
        {
            // Arrange

            int a = 0;
            int b = 0;
            int c = 0;

            // Act

            (int? x1, int? x2) = Solver.segundoGrado(a, b, c);


            //Assert
            Assert.Equal(x1, x2);

            Assert.Null(x1);
            Assert.Null(x2);
        }
    }
}
