using Jugadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comprobaciones;
using Jugadores;
using Barajas;

namespace Juego
{
    public class Poker : Juego
    {
        static int jugadoresMinimos = 2;
        static int jugadoresMaximo = 10;
        int numeroDeCartasPorJugador = 5;

        public static IDictionary<int, string> numeros = new Dictionary<int, string>();

        public Poker(List<Jugador> jugadoresParam) : base(jugadoresParam)
        {
            if (jugadoresParam.Count < jugadoresMinimos || jugadoresParam.Count > jugadoresMaximo)
            {
                throw new Exception($"No se puede empezar un poker con esta cantidad de jugadores: {jugadoresParam.Count}. (Se necesita tener entre 2 y 10 jugadores)");
            }
            baraja = new Baraja(new BarajaFrancesa());
            jugadores = jugadoresParam;
            RepartirCartas(jugadores);
        }

        public override string[] ComprobarGanadores()
        {
            ComprobacionesPoker poker = new ComprobacionesPoker();
            return poker.ganadores(jugadores);
        }

        public override void RepartirCartas(List<Jugador> jugadores)
        {
            foreach (Jugador jugador in jugadores)
            {
                jugador.cartas = baraja.DarCarta(numeroDeCartasPorJugador);
            }
        }

        public override void MostrarCartasJugadores()
        {
            ValoresNumeros();
            Console.WriteLine();
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine("Jugador: " + jugador.Nombre);
                foreach (Carta carta in jugador.cartas)
                {
                    string valor = "";
                    numeros.TryGetValue(carta.Numero, out valor!);
                    Console.WriteLine($"{valor} de {carta.Palo}");
                }
                Console.WriteLine();
            };
        }

        public static void ValoresNumeros()
        {
            numeros.Add(2, "2");
            numeros.Add(3, "3");
            numeros.Add(4, "4");
            numeros.Add(5, "5");
            numeros.Add(6, "6");
            numeros.Add(7, "7");
            numeros.Add(8, "8");
            numeros.Add(9, "9");
            numeros.Add(10, "10");
            numeros.Add(11, "J");
            numeros.Add(12, "Q");
            numeros.Add(13, "K");
            numeros.Add(14, "AS");
        }
    }
}
