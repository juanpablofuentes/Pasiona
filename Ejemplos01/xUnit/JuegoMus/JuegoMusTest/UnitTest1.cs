using JuegosCartas;

namespace JuegoMusTest
{
    public class ValidarMus
    {
        [Fact]
        public void ValidarCreacion()
        {
            //Arrange

            Mus JuegoMus = new Mus(new Jugador("Rosa"), new Jugador("Luis"), new Jugador("Eva"), new Jugador("Ana"));

            //Act

            var mazo1 = JuegoMus.Jugadores[0].Mano;
            var mazo2 = JuegoMus.Jugadores[1].Mano;
            var mazo3 = JuegoMus.Jugadores[2].Mano;
            var mazo4 = JuegoMus.Jugadores[3].Mano;

            //Assert
            Assert.NotNull(JuegoMus.Jugadores);
            Assert.NotNull(JuegoMus.Jugadores[0].Mano);
            Assert.Equal(4,mazo1.Count);
            Assert.Equal(4,mazo2.Count);
            Assert.Equal(4,mazo3.Count);
            Assert.Equal(4,mazo4.Count);
        }

        [Fact]
        public void ValidarGrande()
        {
            //Arrange
            Mus JuegoMus = new Mus(new Jugador("Rosa"), new Jugador("Luis"), new Jugador("Eva"), new Jugador("Ana"));

            JuegoMus.Jugadores[0].Mano = new List<Carta>() { new Carta("Oros", 12), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 1) };
            JuegoMus.Jugadores[1].Mano = new List<Carta>() { new Carta("Oros", 12), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 2) };
            JuegoMus.Jugadores[2].Mano = new List<Carta>() { new Carta("Oros", 11), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 2) };
            JuegoMus.Jugadores[3].Mano = new List<Carta>() { new Carta("Oros", 11), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 2) };

            //Act

            var ganador = JuegoMus.AGrande();

            //Assert

            Assert.Equal(ganador, JuegoMus.Jugadores[1]);

            JuegoMus.Jugadores[0].Mano = new List<Carta>() { new Carta("Oros", 12), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 1) };
            JuegoMus.Jugadores[1].Mano = new List<Carta>() { new Carta("Oros", 12), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 2) };
            JuegoMus.Jugadores[2].Mano = new List<Carta>() { new Carta("Oros", 11), new Carta("Oros", 11), new Carta("Oros", 5), new Carta("Oros", 2) };
            JuegoMus.Jugadores[3].Mano = new List<Carta>() { new Carta("Oros", 12), new Carta("Oros", 12), new Carta("Oros", 5), new Carta("Oros", 2) };

            //Act

             ganador = JuegoMus.AGrande();

            //Assert

            Assert.Equal(ganador, JuegoMus.Jugadores[3]);
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4},10)]
        [InlineData(new int[] {11,2,3,4},19)]
        [InlineData(new int[] {11,12,3,4},27)]
        [InlineData(new int[] {11,12,10,4},32)]
        [InlineData(new int[] {11,12,10,1},38)]
        public void ValidarNumeroJuego(int[] cartas, int valor)
        {

            //Arrange
            Mus JuegoMus = new Mus(new Jugador("Rosa"), new Jugador("Luis"), new Jugador("Eva"), new Jugador("Ana"));

            //Act
            int valorJuego = JuegoMus.NumJuego(cartas);

            //Assert
            Assert.Equal(valorJuego, valor);   
        }
    }
}