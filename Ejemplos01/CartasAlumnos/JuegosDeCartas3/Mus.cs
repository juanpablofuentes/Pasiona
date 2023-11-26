using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    internal class Mus : Juego
    {
        public Mus(Jugador[] jugadores)
        {
            if (jugadores.Length != 4) { throw new ArgumentException("El mus es un juego de 4 jugadores"); }

            Baraja espanola = new Baraja(new Espanola());
            espanola.Mezclar();
            Repartir(jugadores, espanola, 4);

            Console.WriteLine("Ganador grande: " + Grande(jugadores));
            Console.WriteLine("Ganador pequeña: " + Chica(jugadores));
            Console.WriteLine("Ganador pares: " + Pares(jugadores));
            Console.WriteLine("Ganador juego: " + Juego(jugadores));
        }

        public Jugador Grande(Jugador[] jugadores)
        {
            foreach (Jugador jugador in jugadores)
            {
                Array.Sort(jugador.VerMano, (a, b) => (b.Numero - a.Numero));
            }

            List<Jugador> participantes = jugadores.ToList();
            List<int> cartas = new List<int>();

            for (int i = 0; i < 4 && participantes.Count > 1; i++)
            {
                for (int j = 0; j < participantes.Count; j++)
                {
                    cartas.Add(participantes[j].VerMano[i].Numero);
                }

                for (int n = 0; n < participantes.Count; n++)
                {
                    if (cartas[n] != cartas.Max())
                    {
                        participantes.RemoveAt(n);
                        cartas.RemoveAt(n);
                        n--;
                    }
                }

                cartas.Clear();
            }

            return participantes[0];
        }

        public Jugador Chica(Jugador[] jugadores)
        {
            foreach (Jugador jugador in jugadores)
            {
                Array.Sort(jugador.VerMano, (a, b) => (a.Numero - b.Numero));
            }

            List<Jugador> participantes = jugadores.ToList();
            List<int> cartas = new List<int>();

            for (int i = 0; i < 4 && participantes.Count > 1; i++)
            {
                for (int j = 0; j < participantes.Count; j++)
                {
                    cartas.Add(participantes[j].VerMano[i].Numero);
                }

                for (int n = 0; n < participantes.Count; n++)
                {
                    if (cartas[n] != cartas.Min())
                    {
                        participantes.RemoveAt(n);
                        cartas.RemoveAt(n);
                        n--;
                    }
                }

                cartas.Clear();
            }

            if (participantes.Count > 1) { return participantes[0]; }
            else { return participantes[0]; }
        }

        public Jugador Pares(Jugador[] jugadores)
        {
            List<Jugador> participantes = jugadores.ToList();
            List<int> numero = new List<int>();
            List<int> repeticion = new List<int>();
            Dictionary<Jugador, IGrouping<int, Carta>> repeticiones = new Dictionary<Jugador, IGrouping<int, Carta>>();

            foreach (Jugador jugador in jugadores)
            {
                Array.Sort(jugador.VerMano, (a, b) => (b.Numero - a.Numero));
            }

            for (int i = 0; i < participantes.Count; i++)
            {
                IGrouping<int, Carta> maximo = participantes[i].VerMano.GroupBy(c => c.Numero).MaxBy(x => x.Count())!;
                repeticiones.Add(participantes[i], maximo);
            }

            foreach(var n in repeticiones)
            {
                numero.Add(n.Value.Key);
                repeticion.Add(n.Value.Count());
            }

            for (int i = 0; i < participantes.Count() && participantes.Count() > 1; i++)
            {
                if (repeticion[i] != repeticion.Max())
                {
                    repeticion.RemoveAt(i);
                    numero.RemoveAt(i);
                    participantes.RemoveAt(i);
                }
            }

            for (int i = 0; i < participantes.Count() && participantes.Count() > 1; i++)
            {
                if (numero[i] != numero.Max())
                {
                    repeticion.RemoveAt(i);
                    numero.RemoveAt(i);
                    participantes.RemoveAt(i);
                }
            }

            return participantes[0];
        }

        public Jugador Juego(Jugador[] jugadores)
        {
            List<int> sumaCartas = new List<int>();
            int suma, count = 0;

            for (int i = 0; i < jugadores.Length; i++)
            {
                suma = 0;
                for (int j = 0; j < 4; j++)
                {


                    if (jugadores[i].VerMano[j].Numero > 7)
                    {
                        jugadores[i].VerMano[j].Numero = 10;
                    }
                    suma += jugadores[i].VerMano[j].Numero;
                }
                sumaCartas.Add(suma);
            }

            if (sumaCartas.Max() <= 31)
            {
                foreach (int numero in sumaCartas)
                {
                    if (numero == sumaCartas.Max()) { count++; }
                }

                if (count == 1) { return jugadores[sumaCartas.IndexOf(sumaCartas.Max())]; }
                else { return jugadores[sumaCartas.IndexOf(sumaCartas.Max())]; }
            }

            else
            {
                int[] sumas = new int[] { 32, 40, 37, 36, 35, 34, 33 };

                foreach (int s in sumas)
                {
                    foreach (int n in sumaCartas)
                    {
                        if (n == s) { count++; }

                        if (count == 1) { return jugadores[sumaCartas.IndexOf(s)]; }
                        if (count >= 1) { return jugadores[sumaCartas.IndexOf(s)]; }
                    }
                }
            }
            return null;
        }

    }
}
