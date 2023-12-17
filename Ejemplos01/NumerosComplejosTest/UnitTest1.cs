using NumerosComplejos;
namespace NumerosComplejosTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            NumeroComplejo a = new NumeroComplejo(1, 1);
            NumeroComplejo b = new NumeroComplejo(1, 1);
            NumeroComplejo c = new NumeroComplejo(2, 2);

            // Act

            NumeroComplejo suma = a + b;

            // Assert

            Assert.Equal(c, suma);
        }
    }
}