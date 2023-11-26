namespace JuegoCartas
{
    class Juego
    {
        Jugador Jugador1 { get; set; }
        Jugador Jugador2 { get; set; }
        Jugador Jugador3 { get; set; }
        Jugador Jugador4 { get; set; }

        public Juego(Jugador jugador1, Jugador jugador2, Jugador jugador3, Jugador jugador4)
        {
            Jugador1 = jugador1;
            Jugador2 = jugador2;
            Jugador3 = jugador3;
            Jugador4 = jugador4;
        }


    }
}