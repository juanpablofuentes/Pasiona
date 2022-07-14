using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JuegoDeCartas
{
    internal class JuegoPoker : Juego, IPreparacion
    {
        Barajas BarajaFrancesa;
        public JuegoPoker(int numeroJugadores) : base(numeroJugadores)
        {
            BarajaFrancesa = new Barajas(new BarajaFrancesa());
            BarajaFrancesa.RellenarBaraja();
            BarajaFrancesa.Barajar();
            Repartir();
        }

        //ESTE METO SE BORRARÍA Y SE DEJARÍA EL REPARTIR DE FORMA ALEATORIA
        public void Inicializar()
        {
            //ESCALERA REAL
            //Carta carta1 = new Carta("diamantes", "10", 10);
            //Carta carta2 = new Carta("diamantes", "J", 11);
            //Carta carta3 = new Carta("diamantes", "Q", 12);
            //Carta carta4 = new Carta("diamantes", "K", 13);
            //Carta carta5 = new Carta("diamantes", "A", 14);

            //SIN MANO
            //Carta carta1 = new Carta("corazones", "11", 11);
            //Carta carta2 = new Carta("trébol", "2", 2);
            //Carta carta3 = new Carta("trébol", "7", 7);
            //Carta carta4 = new Carta("picas", "10", 10);
            //Carta carta5 = new Carta("picas", "3", 3);

            //UNA PAREJA
            //Carta carta1 = new Carta("corazones", "10", 10);
            //Carta carta2 = new Carta("trébol", "10", 10);
            //Carta carta3 = new Carta("diamantes", "8", 8);
            //Carta carta4 = new Carta("corazones", "2", 2);
            //Carta carta5 = new Carta("picas", "1", 1);

            //TRIO
            //Carta carta1 = new Carta("corazones", "10", 10);
            //Carta carta2 = new Carta("diamantes", "10", 10);
            //Carta carta3 = new Carta("trébol", "10", 10);
            //Carta carta4 = new Carta("diamantes", "2", 2);
            //Carta carta5 = new Carta("diamantes", "1", 1);

            //COLOR
            //Carta carta1 = new Carta("corazones", "10", 10);
            //Carta carta2 = new Carta("corazones", "10", 10);
            //Carta carta3 = new Carta("corazones", "10", 10);
            //Carta carta4 = new Carta("corazones", "2", 2);
            //Carta carta5 = new Carta("corazones", "1", 1);

            //ESCALERA COLOR
            //Carta carta1 = new Carta("corazones", "5", 5);
            //Carta carta2 = new Carta("corazones", "4", 4);
            //Carta carta3 = new Carta("corazones", "3", 3);
            //Carta carta4 = new Carta("corazones", "2", 2);
            //Carta carta5 = new Carta("corazones", "1", 1);

            //PAREJA
            //Carta carta1 = new Carta("diamantes", "3", 3);
            //Carta carta2 = new Carta("picas", "3", 3);
            //Carta carta3 = new Carta("trébol", "2", 2);
            //Carta carta4 = new Carta("corazones", "4", 4);
            //Carta carta5 = new Carta("diamantes", "5", 5);

            //FULL HOUSE
            Carta carta1 = new Carta("corazones", "J", 11);
            Carta carta2 = new Carta("picas", "J", 11);
            Carta carta3 = new Carta("trébol", "7", 7);
            Carta carta4 = new Carta("picas", "7", 7);
            Carta carta5 = new Carta("picas", "7", 7);

            //FULL HOUSE
            //Carta carta6 = new Carta("corazones", "J", 11);
            //Carta carta7 = new Carta("picas", "J", 11);
            //Carta carta8 = new Carta("trébol", "7", 7);
            //Carta carta9 = new Carta("picas", "7", 7);
            //Carta carta10 = new Carta("picas", "7", 7);

            //DOBLE PAREJA
            Carta carta6 = new Carta("corazones", "J", 11);
            Carta carta7 = new Carta("trébol", "J", 11);
            Carta carta8 = new Carta("trébol", "5", 5);
            Carta carta9 = new Carta("picas", "7", 7);
            Carta carta10 = new Carta("picas", "7", 7);

            //ESCALERA
            //Carta carta6 = new Carta("corazones", "5", 5);
            //Carta carta7 = new Carta("trébol", "4", 4);
            //Carta carta8 = new Carta("trébol", "3", 3);
            //Carta carta9 = new Carta("picas", "2", 2);
            //Carta carta10 = new Carta("picas", "1", 1);

            //CUATRO IGUALES
            //Carta carta6 = new Carta("corazones", "5", 5);
            //Carta carta7 = new Carta("trébol", "5", 5);
            //Carta carta8 = new Carta("trébol", "5", 5);
            //Carta carta9 = new Carta("picas", "5", 5);
            //Carta carta10 = new Carta("picas", "1", 1);

            //SIN MANO
            //Carta carta6 = new Carta("corazones", "J", 11);
            //Carta carta7 = new Carta("trébol", "2", 2);
            //Carta carta8 = new Carta("trébol", "7", 7);
            //Carta carta9 = new Carta("picas", "10", 10);
            //Carta carta10 = new Carta("picas", "3", 3);

            //Jugador 3
            //CUATRO IGUALES
            //Carta carta11 = new Carta("corazones", "5", 5);
            //Carta carta12 = new Carta("trébol", "5", 5);
            //Carta carta13 = new Carta("trébol", "5", 5);
            //Carta carta14 = new Carta("picas", "5", 5);
            //Carta carta15 = new Carta("picas", "1", 1);

            //Jugador 3
            //FULL HOUSE
            //Carta carta11 = new Carta("corazones", "J", 11);
            //Carta carta12 = new Carta("picas", "J", 11);
            //Carta carta13 = new Carta("trébol", "7", 7);
            //Carta carta14 = new Carta("picas", "7", 7);
            //Carta carta15 = new Carta("picas", "7", 7);

            List<Carta> CartasJugador1 = new List<Carta>(5) { carta1, carta2, carta3, carta4, carta5 };
            List<Carta> CartasJugador2 = new List<Carta>(5) { carta6, carta7, carta8, carta9, carta10 };
            //List<Carta> CartasJugador3 = new List<Carta>(5) { carta11, carta12, carta13, carta14, carta15 };

            Jugador jugador1 = new Jugador("Pepito", 5);
            jugador1.CartasJugador = CartasJugador1;

            Jugador jugador2 = new Jugador("Juanito", 5);
            jugador2.CartasJugador = CartasJugador2;

            //Jugador jugador3 = new Jugador("Joselito", 5);
            //jugador3.CartasJugador = CartasJugador3;
            //AddJugador(jugador1);
            //AddJugador(jugador2);
            ListaJugadores.Add(jugador1);
            ListaJugadores.Add(jugador2);
            //ListaJugadores.Add(jugador3);
        }
        //PARA AÑADIR JUGADOR POR TECLADO
        public override void AddJugador(Jugador jugador)
        {
            //ListaJugadores.Add(jugador);

            //for (int i = 0; i < ListaJugadores.Count; i++)
            //{
            //    if (ListaJugadores[i] is null)
            //    {
            //        ListaJugadores[i] = jugador;
            //        return;
            //    }
            //}
            //throw new Exception("La partida está llena, no podéis ser más!");
        }

        //REPARTIMOS LAS CARTAS UNA VEZ BARAJADAS Y LA BORRAMOS DE LA BARAJA
        public override void Repartir()
        {
            //    int contador = 0;
            //    for (int i = 0; i < ListaJugadores.Count; i++) //poner hasta 5 aquí en vez de comprobar con un if y contador
            //    {
            //        for (int j = 0; j < Baraja.Count; j++)
            //        {
            //            if (contador < 5 && Baraja[j] is not null)
            //            {
            //                ListaJugadores[i].CartasJugador.Add(Baraja[j]);
            //                Baraja.RemoveAt(j);
            //                contador++;
            //            }
            //        }
            //        contador = 0;
            //    }
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
            //MIRAMOS DE MENOS A MAS Y LE AÑADIMOS AL JUGADOR QUE MANO TIENE, SI NO TIENE ESA MANO NO LA AÑADIRÁ
            //otra manera de pasar la tupla:
            //(jugada, numero) = HayUnaPareja(jugador, combinacion);
            var combinacion = Tuple.Create(0, 0);
            combinacion = HayUnaPareja(jugador, combinacion);
            combinacion = HayDoblePareja(jugador, combinacion);
            combinacion = HayUnTrio(jugador, combinacion);
            combinacion = HayEscalera(jugador, combinacion);
            combinacion = HayColor(jugador, combinacion);
            combinacion = HayFullHouse(jugador, combinacion);
            combinacion = HayCuatroIguales(jugador, combinacion);
            combinacion = HayEscaleraColor(jugador, combinacion);
            combinacion = HayEscaleraReal(jugador, combinacion);

            return combinacion;
        }
        public Tuple<int, int> HayUnaPareja(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());

            for (int i = 0; i < jugador.CartasJugador.Count; i++)
            {
                Carta cartaActual = jugador.CartasJugador[i];
                var list = jugador.CartasJugador.FindAll(s => s.Numero.Equals(cartaActual.Numero)).ToList();
                if (list.Count == 2) return Tuple.Create(1, cartaActual.Numero);

            }
            return combinacion;
        }
        public Tuple<int, int> HayDoblePareja(Jugador jugador, Tuple<int, int> combinacion)
        {

            for (int i = 0; i < jugador.CartasJugador.Count; i++)
            {
                Carta cartaActual = jugador.CartasJugador[i];
                var list = jugador.CartasJugador.FindAll(s => (s.Numero.Equals(cartaActual.Numero)) && !(s.Numero.Equals(combinacion.Item2))).ToList();
                if (list.Count == 2)
                {
                    int numeroMax = combinacion.Item2 > cartaActual.Numero ? combinacion.Item2 : cartaActual.Numero;
                    return Tuple.Create(2, numeroMax);
                }
            }
            return combinacion;
        }
        public Tuple<int, int> HayUnTrio(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());
            for (int i = 0; i < jugador.CartasJugador.Count; i++)
            {
                Carta cartaActual = jugador.CartasJugador[i];
                var list = jugador.CartasJugador.FindAll(s => s.Numero.Equals(cartaActual.Numero)).ToList();
                if (list.Count == 3) return Tuple.Create(3, cartaActual.Numero);

            }
            return combinacion;
        }
        public Tuple<int, int> HayEscalera(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());
            int contador = 0;

            for (int i = 0; i < jugador.CartasJugador.Count - 1; i++)
            {
                Carta cartaActual = jugador.CartasJugador[i];
                int valor1 = jugador.CartasJugador[i].Numero;
                int valor2 = jugador.CartasJugador[i + 1].Numero;

                if (valor1 - 1 == valor2)
                {
                    contador++;
                }
                if (contador == jugador.CartasJugador.Count - 1)
                {
                    //devolvemos la carta más grande
                    return Tuple.Create(4, jugador.CartasJugador[0].Numero);
                }
            }
            return combinacion;
        }
        public Tuple<int, int> HayColor(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());

            for (int i = 0; i < jugador.CartasJugador.Count; i++)
            {
                Carta cartaActual = jugador.CartasJugador[i];
                var list = jugador.CartasJugador.FindAll(s => (s.Palo.Equals(cartaActual.Palo))).ToList();
                if (list.Count == 5) return Tuple.Create(5, jugador.CartasJugador[0].Numero);
            }
            return combinacion;
        }

        public Tuple<int, int> HayFullHouse(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());
            if (combinacion.Item1 == 3)
            {
                int valorTrio = combinacion.Item2;
                for (int i = 0; i < jugador.CartasJugador.Count; i++)
                {
                    Carta cartaActual = jugador.CartasJugador[i];
                    var list = jugador.CartasJugador.FindAll(s => (s.Numero.Equals(cartaActual.Numero)) && !(s.Numero.Equals(valorTrio))).ToList();
                    if (list.Count == 2) return Tuple.Create(6, valorTrio);
                }
            }
            return combinacion;
        }
        public Tuple<int, int> HayCuatroIguales(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());
            {
                int valorTrio = combinacion.Item2;
                for (int i = 0; i < jugador.CartasJugador.Count; i++)
                {
                    Carta cartaActual = jugador.CartasJugador[i];
                    var list = jugador.CartasJugador.FindAll(s => (s.Numero.Equals(cartaActual.Numero))).ToList();
                    if (list.Count == 4) return Tuple.Create(7, cartaActual.Numero);
                }
            }
            return combinacion;
        }

        public Tuple<int, int> HayEscaleraColor(Jugador jugador, Tuple<int, int> combinacion)
        {
            if (combinacion.Item1.Equals(5))
            {
                combinacion = HayEscalera(jugador, combinacion);
                if (combinacion.Item1.Equals(4))
                {
                    return combinacion = Tuple.Create(8, jugador.CartasJugador[0].Numero);
                }
            }
            return combinacion;
        }
        public Tuple<int, int> HayEscaleraReal(Jugador jugador, Tuple<int, int> combinacion)
        {
            jugador.CartasJugador.Sort(new comparador());

            if (jugador.CartasJugador[0].Valor.Equals("A") && combinacion.Item1.Equals(8))
            {
                return combinacion = Tuple.Create(9, jugador.CartasJugador[0].Numero);
            }
            return combinacion;
        }
        public List<Jugador> BuscarGanador(List<Jugador> listaGanadores, JuegoPoker juegoPoker)
        {
            int num = 0;
            List<Jugador> listaGanadoresAux = new List<Jugador>();
            if (listaGanadores.Count > 1)
            {
                //hay empate de manos
                while (listaGanadores.Count != 1 && num < juegoPoker.ListaJugadores[0].CartasJugador.Count)
                {
                    listaGanadoresAux = Desempatar(listaGanadores, num);
                    num++;
                }
            }
            else if (listaGanadores.Count() == 0)
            {
                //ninguno tiene mano, buscamos el que tiene la carta más grande
                listaGanadores = new List<Jugador>(ListaJugadores);
                int numMax = NumeroMaximo(listaGanadores, num);
                Jugador jugadorGanador = new Jugador();

                foreach (Jugador jugador in listaGanadores)
                {
                    foreach (Carta carta in jugador.CartasJugador)
                    {
                        if (carta.Numero.Equals(numMax))
                        {
                            jugadorGanador = jugador;
                            listaGanadoresAux.Add(jugadorGanador);
                            jugador.CombinacionMano = Tuple.Create(0, numMax);
                        }
                    }
                }
            }
            else
            { //si solo hay un ganador se devuelve la lista tal cual
                listaGanadoresAux = new List<Jugador>(listaGanadores);
            }
            return listaGanadoresAux;
        }
        private List<Jugador> Desempatar(List<Jugador> listaGanadores, int num)
        {
            List<Jugador> listaGanadoresAux = new List<Jugador>();

            int? manoMasGrandeEmpate = ManoMasGrandeEmpate(listaGanadores);
            //primero miramos qué mano es mas grande
            foreach (var jugador in listaGanadores)
            {
                if (jugador.CombinacionMano?.Item2 == manoMasGrandeEmpate)
                {
                    listaGanadoresAux.Add(jugador);
                }
            }
            //si sigue habiendo empate, se miran todas las cartas
            if (listaGanadoresAux.Count > 1)
            {
                listaGanadoresAux.Clear();
                foreach (var jugador in listaGanadores)
                {
                    int numeroMaximoRonda = NumeroMaximo(listaGanadores, num);

                    if (jugador.CartasJugador[num].Numero == numeroMaximoRonda)
                    {
                        listaGanadoresAux.Add(jugador);
                    }
                }
            }
            return listaGanadoresAux;
        }

        public int? ManoMasGrandeEmpate(List<Jugador> listaGanadores)
        {
            int? manoGrande = 0;
            foreach (Jugador jugador in listaGanadores)
            {
                if (manoGrande < jugador.CombinacionMano?.Item2)
                {
                    manoGrande = jugador.CombinacionMano?.Item2;
                }
            }
            return manoGrande;
        }

        public int NumeroMaximo(List<Jugador> listaGanadores, int num)
        {
            int numeroMaximo = 0;
            for (int i = 0; i < listaGanadores.Count; i++)
            {
                if (numeroMaximo < listaGanadores[i].CartasJugador[num].Numero)
                {
                    numeroMaximo = listaGanadores[i].CartasJugador[num].Numero;
                }
            }
            return numeroMaximo;
        }

        public List<Jugador> ManoMasGrande()
        {
            List<Jugador> listaGanadores = new List<Jugador>();
            var ordenarManos = ListaJugadores.OrderByDescending(p => p.CombinacionMano?.Item1).ToList();
            Jugador jugadorManoAlta = ordenarManos.First();
            int? valorManoAlta = jugadorManoAlta.CombinacionMano?.Item1;

            //añadimos los jugadores con la mano más alta
            foreach (Jugador jugador in ListaJugadores)
            {
                if (jugador.CombinacionMano?.Item2 != 0)
                {
                    int? valorMano = jugador.CombinacionMano?.Item1;
                    if (valorMano == valorManoAlta)
                    {
                        listaGanadores.Add(jugador);
                    }
                }
            }
            return listaGanadores;
        }

        internal string NombresManos(Jugador jugador)
        {
            var nombresManos = new List<(int, string)>
            {
              (1, "Una pareja"),
              (2, "Doble pareja"),
              (3, "Trio"),
              (4, "Escalera"),
              (5, "Color"),
              (6, "Full house"),
              (7, "Cuatro iguales"),
              (8, "Escalera color"),
              (9, "Escalera real")
            };
            string nombre = "No tiene mano";

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








