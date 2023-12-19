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
        public void TodoCeroNull()
        {
            // Arrange

            double a = 0;
            double b = 0;
            double c = 0;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);


            //Assert
            Assert.Null(x1);
            Assert.Null(x2);
        }

        [Fact]
        public void LasxCeroNull()
        {
            // Arrange

            double a = 0;
            double b = 0;
            double c = 1;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);

            
            //Assert
            Assert.Null(x1);
            Assert.Null(x2);
        }
        [Fact]
        public void DiscriminanteNegativo()
        {
            // Arrange

            double a = 2;
            double b = 1;
            double c = 1;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);


            //Assert
            Assert.Null(x1);
            Assert.Null(x2);
        }
        public void UnaSolucion()
        {
            // Arrange

            double a = 1;
            double b = 2;
            double c = 1;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);


            //Assert
            Assert.Equal(x1,-1);
            Assert.Null(x2);
        }
        public void DosSoluciones()
        {
            // Arrange

            double a = 1;
            double b = 2;
            double c = -15;

            // Act

            (double? x1, double? x2) = Solver.segundoGrado(a, b, c);


            //Assert
            Assert.Equal(x1, 3);
            Assert.Equal(x1, -5);

        }
    }
}
