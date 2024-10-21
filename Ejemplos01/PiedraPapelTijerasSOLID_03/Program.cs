using Juego_v3;

Jugador eva = new Jugador("Eva", new Teclado());

Jugador juan = new Jugador("Juan", new Teclado());
Juego ppt = new Juego(eva, juan, new Colores());
Console.WriteLine(ppt.jugar());