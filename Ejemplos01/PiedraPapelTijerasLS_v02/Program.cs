using Juego_v2;

Jugador eva = new JugadorHumano("Eva");
Jugador juan = new JugadorHumano("Juan");
Juego game = new JuegoPPT(eva, juan);
for(int i = 0; i < 2; i++) { 
    Console.WriteLine("Ganador: " + game.jugar());
}