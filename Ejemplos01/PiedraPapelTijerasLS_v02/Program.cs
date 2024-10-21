using Juego_v2;

Jugador eva = new JugadorCPU("Eva");
Jugador juan = new JugadorCPU("Juan");
Juego game = new JuegoPPT(eva, juan);
for(int i = 0; i < 5; i++) { 
    Console.WriteLine("Ganador: " + game.jugar());
}