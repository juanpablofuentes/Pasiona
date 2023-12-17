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
        public void TodosCero()
        {
            // Arrange

            double a = 0;
            double b = 0;
            double c = 0;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);


            //Assert
            Assert.Equal(x1, x2);

            Assert.Null(x1);
            Assert.Null(x2);
        }

        [Fact]
        public void XCero()
        {
            // Arrange

            double a = 0;
            double b = 0;
            double c = 1;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);

            
            //Assert
            Assert.Equal(x1, x2);

            Assert.Null(x1);
            Assert.Null(x2);
        }


    }
}
