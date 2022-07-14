using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartas {
    internal class Poquer : IJuegoCartas{
        private IJugador [] _jugadores;
        private Baraja _baraja;
        private BarajaFrancesa _barajaFrancesa;
        private bool _finalPartida;

        public Poquer(IJugador [] jugadores) {
            _jugadores = jugadores;
            _barajaFrancesa = new BarajaFrancesa();
            _baraja = new Baraja(_barajaFrancesa);
            _finalPartida = false;
        }

        public Poquer(IGetJugadores getJugadores) : this(getJugadores.PedirJugadores(2, 10)) {

        }

        public Baraja Baraja () => _baraja;

        public int NumeroMano () => 5;

        public bool FinalPartida () => _finalPartida;

        public IJugador [] Jugadores () => _jugadores;

        public void PasarRonda () {
            _finalPartida = true;
        }

        public void Jugador (IJugador jugador) {

            Descartar(jugador, 0, 4);

            jugador.Mano = _baraja.darMano(this, jugador.Mano);

            jugador.Mano = ordenarMano(jugador.Mano);

            jugador.mostrarMano();

        }

        public void repartir () {
            foreach (IJugador jugador in Jugadores()) {
                jugador.Mano = Baraja().darMano(this);
                jugador.Mano = ordenarMano(jugador.Mano);
                jugador.mostrarMano();
            }
        }

        private List<Carta> ordenarMano (List<Carta> _mano) => new List<Carta>(_mano).Sort<Carta>(new SorterCarta(this));

        private class SorterCarta : IComparer<Carta> {
            private Poquer game;
            public SorterCarta(Poquer p) {
                game = p;
            }
            public int Compare (Carta? x, Carta? y) => game.valorCarta(x.Valor) > game.valorCarta(y.Valor) ? 1 : -1;

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


        public IJugador[] JugadorGanador () {

            int jugadorGanador = 0;
            List<Carta> manoGanadora = Jugadores() [jugadorGanador].Mano;
            Jugada jugadaGanadora = valorJugada(manoGanadora);

            for(int i = jugadorGanador+1; i < Jugadores().Length; i++) {

                List<Carta> mano = Jugadores() [i].Mano;
                Jugada jugada = valorJugada(mano);

                if (jugada < jugadaGanadora) {
                    jugadorGanador = i;
                    manoGanadora = mano;
                    jugadaGanadora = jugada;
                }else if(jugada == Jugada.CARTA_MES_ALTA && Jugada.CARTA_MES_ALTA == jugadaGanadora) {

                    string cartaAltaG = cartaAlta(manoGanadora);
                    string cartaAltaI = cartaAlta(mano);

                    if(valorCarta(cartaAltaI) > valorCarta(cartaAltaG)) {
                        jugadorGanador = i;
                        manoGanadora = mano;
                        jugadaGanadora = jugada;
                    }
                }

            }

            return new IJugador [] { Jugadores() [jugadorGanador] };
            //CALCULAR JUGADOR GANADOR
        }

        public int valorCarta (string valor) => Array.IndexOf(new string [] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k", "as"}, valor.ToLower());

        public bool cambiarCarta (List<Carta> mano) {

            string[] cartaStr = Console.ReadLine().ToLower().Split(",");

            Carta cartaCambiar = new CartaFrancesa(cartaStr [0].Trim(), cartaStr [1].Trim());

            if (mano.Contains(cartaCambiar)) {
                mano.Remove(cartaCambiar);
                return true;
            }
                
            
            Console.WriteLine("No tienes esta carta en tu mano");

            return false;

        }

        public string? ordreValors(string valor, bool desc = false) {

            string [] order = _barajaFrancesa.Valores();

            int index = Array.IndexOf(order, valor);

            if (index == -1) return null;

            if (!desc && index < order.Length - 1) return order [index + 1];

            if (desc && index > 0) return order [index - 1];

            return null;
        }

        public string cartaAlta(List<Carta> ma) {

            string [] order = _barajaFrancesa.Valores();

            int index = -1;

            foreach (Carta carta in ma) {
                int indexValor = Array.IndexOf(order, carta.Valor);
                if (indexValor > index) index = indexValor;
            }

            return order [index];

        }


        public bool manoConsecutiva(List<Carta> ma, int numCartes = -1, bool palo = true) {
                        
            int cont = 1;

            while (cont < ma.Count() && (ma [cont - 1].Valor == ordreValors(ma [cont].Valor) /*|| ma [cont - 1].Valor == ordreValors(ma [cont].Valor, true)*/) && (palo ? ma [cont - 1].Palo == ma [cont].Palo : true))
                cont++;

            return cont == (numCartes < 0 ? ma.Count() : numCartes);
        }

        public bool esEscalaReial(List<Carta> ma) => manoConsecutiva(ma) && (cartaAlta(ma) == "as" || cartaAlta(ma) == "as");

        public bool esEscalaColor (List<Carta> ma) => manoConsecutiva(ma) && cartaAlta(ma) != "as";

        public bool esPoquer(List<Carta> ma) {

            Dictionary<string, int> valorQuantitat = new();

            foreach (Carta carta in ma) {
                string valor = carta.Valor;

                if (valorQuantitat.ContainsKey(valor)) {
                    valorQuantitat [valor]++;
                    if (valorQuantitat [valor] == 4) return true;
                }else
                    valorQuantitat.Add(valor, 1);
            }

            return false;
        }

        public bool esFull (List<Carta> ma) {
            Dictionary<string, int> valorQuantitat = new();

            bool cartes2 = false;
            bool cartes3 = false;

            foreach (Carta carta in ma) {
                string valor = carta.Valor;
                if (valorQuantitat.ContainsKey(valor)) 
                    valorQuantitat [valor]++;
                else
                    valorQuantitat.Add(valor, 1);
            }

            foreach (var item in valorQuantitat) {
                if (item.Value == 2) cartes2 = true;
                else if (item.Value == 3) cartes3 = true;
            }

            return cartes2 && cartes3;
        }

        public bool esColor(List<Carta> ma) {

            int cont = 1;

            while (cont < ma.Count && ma [cont - 1].Palo == ma [cont].Palo)
                cont++;

            return cont == ma.Count;

        }

        public bool esEscala (List<Carta> ma) => manoConsecutiva(ma, palo: false);

        public bool esTrio(List<Carta> ma) {
            Dictionary<string, int> valorQuantitat = new();

            foreach (Carta carta in ma) {
                string valor = carta.Valor;

                if (valorQuantitat.ContainsKey(valor)) {
                    valorQuantitat [valor]++;
                    if (valorQuantitat [valor] == 3) return true;
                } else
                    valorQuantitat.Add(valor, 1);
            }

            return false;
        }

        public bool esDobleParella(List<Carta> ma) {

            Dictionary<string, int> valorQuantitat = new();

            int parelles = 0;

            foreach (Carta carta in ma) {
                string valor = carta.Valor;

                if (valorQuantitat.ContainsKey(valor)) {
                    valorQuantitat [valor]++;
                    if (valorQuantitat [valor] == 2) parelles++;
                } else
                    valorQuantitat.Add(valor, 1);
            }

            return parelles >= 2;

        }

        public bool esParella(List<Carta> ma) {

            Dictionary<string, int> valorQuantitat = new();

            foreach (Carta carta in ma) {
                string valor = carta.Valor;

                if (valorQuantitat.ContainsKey(valor)) {
                    valorQuantitat [valor]++;
                    if (valorQuantitat [valor] == 2) return true;
                } else
                    valorQuantitat.Add(valor, 1);
            }

            return false;

        }


        public Jugada valorJugada(List<Carta> ma) {
            if (esEscalaReial(ma)) return Jugada.ESCALA_REIAL;
            if (esEscalaColor(ma)) return Jugada.ESCALA_COLOR;
            if (esPoquer(ma)) return Jugada.POQUER;
            if (esFull(ma)) return Jugada.FULL;
            if (esColor(ma)) return Jugada.COLOR;
            if (esEscala(ma)) return Jugada.ESCALA;
            if (esTrio(ma)) return Jugada.TRIO;
            if (esDobleParella(ma)) return Jugada.DOBLE_PARELLA;
            if (esParella(ma)) return Jugada.PARELLA;

            return Jugada.CARTA_MES_ALTA;
        }

        public string nombreJugada (Jugada jugada) => jugada switch {
            Jugada.ESCALA_REIAL => "escala reial",
            Jugada.ESCALA_COLOR => "escala color",
            Jugada.POQUER => "poquer",
            Jugada.FULL => "full",
            Jugada.COLOR => "color",
            Jugada.ESCALA => "escala",
            Jugada.TRIO => "trio",
            Jugada.DOBLE_PARELLA => "doble pareja",
            Jugada.PARELLA => "pareja",
            Jugada.CARTA_MES_ALTA => "carta més alta",
            _ => "unkown"
        };

    public enum Jugada {
            ESCALA_REIAL, ESCALA_COLOR, POQUER, FULL, COLOR, ESCALA, TRIO, DOBLE_PARELLA, PARELLA, CARTA_MES_ALTA
        }
    }

}
