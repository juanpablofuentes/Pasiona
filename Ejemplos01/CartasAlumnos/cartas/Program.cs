using cartas;

Jugador dani = new Jugador("Dani");
Jugador santi = new Jugador("Santi");
Jugador marc = new Jugador("Marc");
Jugador victor = new Jugador("Victor");


IJugador [] jugadores = new IJugador [] { dani, santi };

//Consola console = new ConsolaMus();

//Mus mus = new Mus(console);

Consola console = new ConsolaPoquer();

Poquer poquer = new Poquer(jugadores);

//Poquer poquer = new Poquer(new Consola());

JuegoCartas juego = new JuegoCartas(poquer, console);

juego.Jugar();