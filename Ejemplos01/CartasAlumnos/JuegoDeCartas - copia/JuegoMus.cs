using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    internal class JuegoMus : Juego, IPreparacion
    {
        Barajas BarajaEspanyola;
        public JuegoMus(int numeroJugadores) : base(numeroJugadores)
        {
            BarajaEspanyola = new Barajas(new BarajaEspanyola());
            BarajaEspanyola.RellenarBaraja();
            BarajaEspanyola.Barajar();
            Repartir();
        }
        public void Inicializar()
        {
            Carta carta1 = new Carta("oros", "2", 2);
            Carta carta2 = new Carta("oros", "2", 2);
            Carta carta3 = new Carta("copas", "caballo", 9);
            Carta carta4 = new Carta("espadas", "caballo", 9);

            Carta carta5 = new Carta("bastos", "A", 1);
            Carta carta6 = new Carta("espadas", "3", 3);
            Carta carta7 = new Carta("oros", "7", 7);
            Carta carta8 = new Carta("espadas", "7", 7);

            List<Carta> CartasJugador1 = new List<Carta>(5) { carta1, carta2, carta3, carta4 };
            List<Carta> CartasJugador2 = new List<Carta>(5) { carta5, carta6, carta7, carta8 };

            Jugador jugador1 = new Jugador("Paquita", 4);
            jugador1.CartasJugador = CartasJugador1;

            Jugador jugador2 = new Jugador("Josefita", 4);
            jugador2.CartasJugador = CartasJugador2;

            //AddJugador(jugador1);
            //AddJugador(jugador2);
            ListaJugadores.Add(jugador1);
            ListaJugadores.Add(jugador2);
        }

        public void AsignarValorMano()
        {
            foreach (Jugador jugador in ListaJugadores)
            {
                jugador.CombinacionMano = ObtenerCombinacionMano(jugador);
            }
        }

        private Tuple<int, int> ObtenerCombinacionMano(Jugador jugador)
        {
            jugador.CartasJugador.Sort(new comparador());
            var combinacion = Tuple.Create(0, 0);
            combinacion = HayJuego(jugador, combinacion);
            combinacion = HayPares(jugador, combinacion);
            combinacion = HayCartaBaja(jugador, combinacion);
            combinacion = HayCartaAlta(jugador, combinacion);

            return combinacion;
        }
        private Tuple<int, int> HayJuego(Jugador jugador, Tuple<int, int> combinacion)
        {
            //TODO falta implementar cambiar figuras por valor 10
            var numeros = jugador.CartasJugador.Select(c => c.Numero).ToList();
            int suma = numeros.Sum();

            if (suma >= 31)
            {
                return Tuple.Create(1, suma);
            }

            return combinacion;
        }
        private Tuple<int, int> HayPares(Jugador jugador, Tuple<int, int> combinacion)
        {
            for (int i = 0; i < jugador.CartasJugador.Count; i++)
            {
                Carta cartaActual = jugador.CartasJugador[i];
                var list = jugador.CartasJugador.FindAll(s => s.Valor.Equals(cartaActual.Valor)).ToList();
                if (list.Count == 2)
                {
                    combinacion = Tuple.Create(2, cartaActual.Numero);
                    return combinacion;
                }
            }
            return combinacion;
        }
        private Tuple<int, int> HayCartaBaja(Jugador jugador, Tuple<int, int> combinacion)
        {
            int numeroMinimoRonda = NumeroMinimo();

            for (int j = 0; j < ListaJugadores[0].CartasJugador.Count; j++)
            {
                if (jugador.CartasJugador[j].Numero == numeroMinimoRonda)
                {
                    combinacion = Tuple.Create(3, numeroMinimoRonda);
                    return combinacion;
                }
            }
            return combinacion;
        }
        public int NumeroMinimo()
        {
            int numeroMinimo = int.MaxValue;
            for (int i = 0; i < ListaJugadores.Count; i++)
            {
                var lista = ListaJugadores[i].CartasJugador.Select(c => c.Numero);
                int numeroMinimoJugador = lista.Min();

                if (numeroMinimo > numeroMinimoJugador)
                {
                    numeroMinimo = numeroMinimoJugador;
                }
            }
            return numeroMinimo;
        }

        private Tuple<int, int> HayCartaAlta(Jugador jugador, Tuple<int, int> combinacion)
        {
            int numeroMaximoRonda = NumeroMaximo();

            for (int j = 0; j < ListaJugadores[0].CartasJugador.Count; j++)
            {
                if (jugador.CartasJugador[j].Numero == numeroMaximoRonda)
                {
                    combinacion = Tuple.Create(4, numeroMaximoRonda);
                    return combinacion;
                }
            }
            return combinacion;
        }

        public int NumeroMaximo()
        {
            int numeroMaximo = 0;
            int num = 0;
            while (num != ListaJugadores[0].CartasJugador.Count)
            {
                for (int i = 0; i < ListaJugadores.Count; i++)
                {
                    if (numeroMaximo < ListaJugadores[i].CartasJugador[num].Numero)
                    {
                        numeroMaximo = ListaJugadores[i].CartasJugador[num].Numero;
                    }
                    num++;
                }
            }
            return numeroMaximo;
        }

        public override void AddJugador(Jugador jugador)
        {
            // throw new NotImplementedException();
        }

        public override void Repartir()
        {
            // throw new NotImplementedException();
        }
        internal string NombresManos(Jugador jugador)
        {
            var nombresManos = new List<(int, string)>
            {
              (1, "Cuarto con pares"),
              (2, "Tercero con juego"),
              (3, "Segundo con carta baja"),
              (4, "Primero con carta alta"),
            };
            string nombre = "Tiene 30 o menos";

            foreach (var nombreMano in nombresManos)
            {
                if (nombreMano.Item1 == jugador.CombinacionMano?.Item1)
                {
                    nombre = nombreMano.Item2;
                    return nombre;
                }
            }
            return nombre;
        }
        internal class comparador : IComparer<Carta?>
        {
            public int Compare(Carta? x, Carta? y)
            {
                Carta a = x;
                Carta b = y;

                if ((a.Numero) > (b.Numero)) { return -1; }
                if ((b.Numero) > (a.Numero)) { return 1; }
                return 0;
            }
        }
    }
}
