namespace JuegoDeCartas
{

    internal class Program
    {
        static void Main(string[] args)
        {

            /*  int tipo = -1;
              bool entra = false;

              while (!entra)
              {
                  Console.WriteLine("¿A qué juego quieres jugar? [POKER/MUS]: ");
                  string nombreJuego = Console.ReadLine();

                  if (string.Equals("poker", nombreJuego, StringComparison.OrdinalIgnoreCase))
                  {
                      tipo = 1;
                      entra = true;
                  }
                  else if (string.Equals("mus", nombreJuego, StringComparison.OrdinalIgnoreCase))
                  {
                      tipo = 2;
                      entra = true;
                  }
                  else
                  {
                      Console.WriteLine("Escribe bien el nombre del juego >:(");
                  }
              }

              Console.WriteLine("¿Cuántos jugadores sereis?");
              int numeroJugadores = Convert.ToInt32(Console.ReadLine());

              if (tipo == 1)
              { */

            //Poker
            int numeroJugadores = 3;
            JuegoPoker juegoPoker = new JuegoPoker(numeroJugadores);
            juegoPoker.Inicializar();
            juegoPoker.AsignarValorMano();
            List<Jugador> listaGanadores = juegoPoker.ManoMasGrande();
            listaGanadores = juegoPoker.BuscarGanador(listaGanadores, juegoPoker);
            string resultado = (listaGanadores.Count() > 1) ? "Empate: " : "Ganador: ";

            //Mostrar ganadores
            foreach (var jugador in listaGanadores)
            {
                string nombreMano = juegoPoker.NombresManos(jugador);
                Console.WriteLine(resultado + jugador.Nombre + ", Mano: " + nombreMano + ", Carta más alta: " + jugador.CombinacionMano?.Item2);
            }

            //Juego mus sin terminar
            JuegoMus juegoMus = new JuegoMus(2);
            juegoMus.Inicializar();
            juegoMus.AsignarValorMano();
        }
        /*else if (tipo == 2)
         {*/
        //MUS
        
        
        /*}
    }
    public static void PedirJugador(JuegoPoker juegoPoker, int numeroJugadores, Jugador jugador)
     {
         int contador = 0;

         while (contador < numeroJugadores)
         {
             si el tipo obj es el tipo de objeto juegopoker...
                 if (obj.GetType().IsInstanceOfType(typeof(JuegoPoker)))
                 ((JuegoPoker)obj).AddJugador(jugador);
             {
                 {
                     Console.WriteLine("Añade el nombre del jugador:");
                     Jugador jugador = new Jugador(Console.ReadLine());
                     juegoPoker.AddJugador(jugador);

                     contador++;
                 }
             }
         }
     } */
    } 
}