using JuegosCartas;

namespace JuegosCartasTest
{
    public class UnitTest1
    {
        [Fact]
        public void ValidarCreacion()
        {
            //Arrange

            Mus2 JuegoMus = new Mus2(new Jugador("Rosa"), new Jugador("Luis"), new Jugador("Eva"), new Jugador("Ana"));

            //Act

            var mazo1 = JuegoMus.Jugadores[0].Mano;
            var mazo2 = JuegoMus.Jugadores[1].Mano;
            var mazo3 = JuegoMus.Jugadores[2].Mano;
            var mazo4 = JuegoMus.Jugadores[3].Mano;

            //Assert
            Assert.NotNull(JuegoMus.Jugadores);
            //Assert.NotNull(JuegoMus.Jugadores[0].Mano);
        }
    }
}