using Juego_v3;

Jugador eva = new Jugador("Eva", new CPU());

Jugador juan = new Jugador("Juan", new CPU());
Juego ppt = new Juego(eva, juan, new JuegoPPTLS());
Console.WriteLine(ppt.jugar());