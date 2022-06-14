using Juego_v2;

Jugador eva = new JugadorHumano("Eva");
Jugador juan = new JugadorCPU("Juan");
Juego game = new JuegoPPTLS(eva, juan);

    Console.WriteLine("Ganador: " + game.jugar());