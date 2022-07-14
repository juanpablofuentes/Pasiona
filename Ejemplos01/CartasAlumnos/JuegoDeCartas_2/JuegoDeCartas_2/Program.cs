// See https://aka.ms/new-console-template for more information
using JuegoDeCartas_2;

Jugador jugador1 = new Jugador("Eva");
Jugador jugador2 = new Jugador("Ana");
Jugador jugador3 = new Jugador("Rosa");
Jugador jugador4 = new Jugador("Ot");

List<Jugador> jugadorList = new List<Jugador>()
{
    jugador1,
    jugador2,
    jugador3,
    jugador4,

};

MusJuego mus = new MusJuego(jugadorList);


mus.ganadores();

//PokerJuego pk = new PokerJuego(jugadorList);

