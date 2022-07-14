using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class Mus : IJuegoCartas {

        private IJugador [] jugadores;
        private Baraja baraja;
        private bool mus;

        public Mus (IJugador [] jugadores) {
            this.jugadores = jugadores;
            baraja = new Baraja(new BarajaEspanola());
            mus = true;
        }

        public Mus (IGetJugadores jugadores) : this(jugadores.PedirJugadores(4,4)){
        }

        public Baraja Baraja () => baraja;

        public bool FinalPartida () => !mus;
        public void Jugador (IJugador jugador) {

            Console.Write($"Jugador {jugador.Nombre}, mus? [Y/n] ");

            if (Console.ReadLine().ToLower() != "y") mus = false;

        }
        public IJugador [] Jugadores () => jugadores;
        public IJugador[] JugadorGanador () {

            IJugador [] jugadorGanador = new IJugador [4];

            Array.Sort(jugadores, new orderByJugador(GanadorGrande));

            jugadorGanador [0] = jugadores.Last();

            Array.Sort(jugadores, new orderByJugador(GanadorChica));

            jugadorGanador [1] = jugadores.Last();

            Array.Sort(jugadores, new orderByJugador(GanadorPares));

            jugadorGanador [2] = jugadores.Last();

            Array.Sort(jugadores, new orderByJugador(GanadorJuego));

            jugadorGanador [3] = jugadores.Last();

            return jugadorGanador;

        }

        public int NumeroMano () => 4;
        public void PasarRonda () {

            if (mus) {

                foreach (IJugador jugador in jugadores) {
                    Descartar(jugador, 1, 4);
                    baraja.darMano(this, jugador.Mano);
                    jugador.mostrarMano();
                }
            }

        }

        public void Descartar (IJugador jugador, int min, int max) {

            int cambiar;


            do {
                Console.Write($"Jugador {jugador.Nombre}, cuantas cartas quieres cambiar? ");
                int.TryParse(Console.ReadLine(), out cambiar);

            } while (cambiar > max || cambiar < min);

            for (int i = 0; i < cambiar; i++) {

                do {
                    Console.Write($"Escribe la carta {i + 1} a cambiar: ");

                } while (!cambiarCarta(jugador.Mano));

            }

        }

        public bool cambiarCarta (List<Carta> mano) {

            string [] cartaStr = Console.ReadLine().ToLower().Split(",");

            Carta cartaCambiar = new CartaEspanola(cartaStr [0].Trim(), cartaStr [1].Trim());

            if (mano.Contains(cartaCambiar)) {
                mano.Remove(cartaCambiar);
                return true;
            }

            Console.WriteLine("No tienes esta carta en tu mano");

            return false;

        }
        public int valorCartas (string valor) {
            string [] pt10 = new string [] { "sota", "caballo", "rey"};

            valor = valor.ToLower();

            if (pt10.Contains(valor)) return 10+Array.IndexOf(pt10, valor);

            if (valor == "as") return 1;

            int valorPt;
            int.TryParse(valor, out valorPt);

            return valorPt;

        }

        private IJugador GanadorGrande(IJugador j1, IJugador j2) {

            (double valorJ1, double valorJ2) valores = CompararManos(j1, j2);

            //Console.WriteLine(j1.Nombre + " VS " + j2.Nombre);

            //if (valores.valorJ2 > valores.valorJ1) Console.WriteLine("Gana " + j2.Nombre + " - " + valores.valorJ2);
            //else Console.WriteLine("Gana " + j1.Nombre + " - " + valores.valorJ1);

            return valores.valorJ2 > valores.valorJ1 ? j2 : j1;

        }

        private IJugador GanadorChica (IJugador j1, IJugador j2) {

            (double valorJ1, double valorJ2) valores = CompararManos(j1, j2);
            
            return valores.valorJ2 < valores.valorJ1 ? j2 : j1;

        }

        private IJugador GanadorPares(IJugador j1, IJugador j2) {

            Dictionary<string, int> paresj1 = new Dictionary<string, int>();
            Dictionary<string, int> paresj2 = new Dictionary<string, int>();

            for(int i = 0; i < NumeroMano(); i++) {

                if (!paresj1.ContainsKey(j1.Mano [i].Valor)) paresj1 [j1.Mano [i].Valor] = 0;
                if (!paresj2.ContainsKey(j2.Mano [i].Valor)) paresj2 [j2.Mano [i].Valor] = 0;

                paresj1 [j1.Mano [i].Valor] ++;
                paresj2 [j2.Mano [i].Valor] ++;

            }

            int valorj1 = 0, valorj2 = 0;

            foreach(var kv in paresj1) {

                if (kv.Value > 1) valorj1 += kv.Value;

            }

            foreach (var kv in paresj2) {

                if (kv.Value > 1) valorj2 += kv.Value;

            }

            return valorj2 > valorj1 ? j2 : j1;
        }

        private IJugador GanadorJuego (IJugador j1, IJugador j2) {
            int [] valoresOrden = new int [] { 33, 34, 35, 36, 37, 38, 39, 40, 32, 31 };

            (double valorj1, double valorj2) valores = CompararManos(j1, j2);

            if(valores.valorj1 < 31 && valores.valorj2 < 31) return valores.valorj2 > valores.valorj1 ? j2 : j1;

            if (valores.valorj1 < 31) return j2;
            if (valores.valorj2 < 31) return j1;

            return Array.IndexOf(valoresOrden, valores.valorj2) > Array.IndexOf(valoresOrden, valores.valorj1) ? j2 : j1;

        }

        private (double,double) CompararManos(IJugador j1, IJugador j2) {
            double valorJ1 = 0, valorJ2 = 0;

            for (int i = 0; i < NumeroMano(); i++) {

                //Console.WriteLine(j1.Mano [i].Valor + " - " + valorCartas(j1.Mano [i].Valor) + " - " + 12);
                //Console.WriteLine(j2.Mano [i].Valor + " - " + valorCartas(j2.Mano [i].Valor) + " - " + 12);

                valorJ1 += Math.Pow(valorCartas(j1.Mano [i].Valor), baraja.Valores().Length);
                valorJ2 += Math.Pow(valorCartas(j2.Mano [i].Valor), baraja.Valores().Length);

            }

            //Console.WriteLine(j1.Nombre + ": " + valorJ1 + " - " + j2.Nombre + ": " + valorJ2);

            return (valorJ1, valorJ2);
        }

        private class orderByJugador : IComparer<IJugador> {

            private Func<IJugador, IJugador, IJugador> order;
            public orderByJugador (Func<IJugador, IJugador, IJugador> _order) {
                order = _order;
            }

            public int Compare (IJugador? x, IJugador? y) => order(x!, y!) == y ? -1 : 1;

                //Console.WriteLine(x.Nombre + " VS " + y.Nombre);

                //if (c == -1) Console.WriteLine("Gana " + y.Nombre);
                //else Console.WriteLine("Gana " + x.Nombre);
        }
    }
}
