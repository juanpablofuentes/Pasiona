using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NumerosComplejos;

namespace PruebasUnitariasNumerosComplejos
{
    public class UnitTest1
    {
        [Fact]
        public void PruebaResta()
        {
            // Arrange
            NumeroComplejo a = new NumeroComplejo(5, 5);
            NumeroComplejo b = new NumeroComplejo(2, 2);

            // Act

            var c = a - b;

            // Assert
            Assert.Equal(c, new NumeroComplejo(3, 3));
        }
        [Fact]
        public void PruebaMultiplicacion()
        {
            // Arrange
            NumeroComplejo a = new NumeroComplejo(1, 1);
            NumeroComplejo b = new NumeroComplejo(1, 1);

            // Act

            var c = a * b;

            // Assert
            Assert.Equal(c, new NumeroComplejo(0, 2));
            // Comprueba que la multiplicación funciona
            Assert.True(c.ParteReal == 0 && c.ParteImaginaria == 2);
        }

        [Fact]
        public void Test()
        {
            // Arrange 

            NumeroComplejo a = new NumeroComplejo(1, 1);
            NumeroComplejo b = new NumeroComplejo(1, 1);

            // Act
            var c = a + b;
            var d = a - b;
            var e = a * b;

            // Assert

            Assert.Equal(c, new NumeroComplejo(2, 2));
            Assert.Equal(d, new NumeroComplejo(0, 0));
            Assert.Equal(e, new NumeroComplejo(0, 2));

        }

        [Theory]
        [InlineData(1, 1, 1, 1, 2, 2)]
        [InlineData(-1, 1, 1, -1, 0, 0)]
        [InlineData(-1, -1, 1, 1, 0, 0)]
        [InlineData(-1, -1, -1, -1, -2, -2)]
        public void TestSumaTeoria(double real1, double img1, double real2, double img2, double realres, double imgres)
        {
            var a = new NumeroComplejo(real1, img1);
            var b = new NumeroComplejo(real2, img2);

            var c = a + b;

            Assert.Equal(c, new NumeroComplejo(realres, imgres));
        }
    }
}