using Juego_v1;

Jugador eva = new Jugador("Eva");
Jugador juan = new Jugador("Juan");
Juego game = new Juego(eva, juan);
for(int i = 0;i< 5;i++)
Console.WriteLine("Ganador: " + game.jugar());