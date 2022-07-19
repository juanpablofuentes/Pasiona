using PruebaxUnit;

namespace testCuadrado
{
    public class UnitTest1
    {
        [Fact]
        public void ComprobarArea()
        {
            //Arrange: Crear los objetos necesarios

            Cuadrado mic = new Cuadrado(5);

            //Act

            double area = mic.area();

            //Assert

            Assert.Equal(area, 5 * 5);
        }

        [Theory]
        [InlineData(5, 25)]
        [InlineData(3, 9)]
        [InlineData(10, 100)]
        public void ValidarArea(int lado, int valor)
        {
            //Arrange: Crear los objetos necesarios

            Cuadrado mic = new Cuadrado(lado);

            //Act

            double area = mic.area();

            //Assert

            Assert.Equal(area, valor);

        }
    }
}