using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas_2
{
    internal class MusJuego : IJuego
    {
        private List<Jugador> jugadorList;
        public Baraja Baraja { get; set; }
        private string[] palos = { "ESPADAS", "OROS", "COPAS", "BASTOS" };
        private int[] valores = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        


        public MusJuego(List<Jugador> listaJugadores)
        {

            jugadorList = listaJugadores;
            crearPartida();
            asignarCartas();
        }

        public void crearPartida()
        {
            Baraja = new Baraja(palos, valores);

        }
        public void asignarCartas()
        {
            foreach (Jugador jugador in jugadorList)
            {
                jugador.MisCartas1 = Baraja.repartirCartas(4);
            }
        }
        public string alMayor()
        {
            int max = 0;
            Jugador jugadorMayor = new Jugador();

            for (int i = 0; i < jugadorList.Count; i++)
            {

                if (max < jugadorList[i].MisCartas1[0].valor)
                {
                    max = jugadorList[i].MisCartas1[0].valor;
                    jugadorMayor = jugadorList[i];

                }
                else if (max == jugadorList[i].MisCartas1[0].valor)
                {
                    for (int j = 1; j < jugadorList[i].MisCartas1.Length; j++)
                    {
                        if (max < jugadorList[i].MisCartas1[j].valor)
                        {
                            max = jugadorList[i].MisCartas1[j].valor;
                            jugadorMayor = jugadorList[i];
                        }

                    }
                }

            }

            return jugadorMayor.Nombre +" con una carta de valor "+max;
        }
        public string alMenor() 
        {

            Jugador jugadorMenor = new Jugador();
            int min = jugadorList[0].MisCartas1[3].valor;
            for (int i = 0; i < jugadorList.Count; i++)
            {
                if (min > jugadorList[i].MisCartas1[3].valor)
                {
                    min = jugadorList[i].MisCartas1[3].valor;
                    jugadorMenor = jugadorList[i];
                }
                else if (min == jugadorList[i].MisCartas1[3].valor)
                {
                    for (int j = jugadorList[i].MisCartas1.Length - 1; j > 0; j--)
                    {
                        if (min > jugadorList[i].MisCartas1[j].valor)
                        {
                            min = jugadorList[i].MisCartas1[j].valor;
                            jugadorMenor = jugadorList[i];
                        }

                    }
                }

            }

            return jugadorMenor.Nombre + " con una carta de valor " + min; ;
        }

        public string par()
        {
            Jugador jugadorAlPar = new Jugador();
            int[] pares = new int[jugadorList.Count];
            for (int i = 0; i < jugadorList.Count; i++)
            {
                int val = jugadorList[i].MisCartas1[i].valor;
                int count = 0;
                for (int j = 0; j < jugadorList[i].MisCartas1.Length; j++)
                {
                    if (val == jugadorList[i].MisCartas1[j].valor)
                    {
                        count += 1;
                    }

                }
                //Console.WriteLine(val);
                pares[i]=count;

            }
            //for (int i = 0; i < pares.Length; i++)
            //{
            //    Console.WriteLine(pares[i]);
            //}

            return jugadorAlPar.Nombre;
        }
        public void ganadorJuego()
        {
            Jugador jugadorJuego = new Jugador();
            int[] maximos = new int[jugadorList.Count];
            for (int i = 0; i < jugadorList.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < jugadorList[i].MisCartas1.Length; j++)
                {
                    sum += jugadorList[i].MisCartas1[j].valor;
                }
                maximos[i] = sum;
             

            }
            Array.Sort(maximos);

            
            //for (int i = 0; i < maximos.Length; i++)
            //{
            //    Console.WriteLine(maximos[i]);
            //}
            
        }

        public void ganadores()
        {
            Console.WriteLine("Ganador al mayor es " + alMayor());
            Console.WriteLine("Ganador al menor es " + alMenor());
            //Console.WriteLine("Ganador al par es " + par());
        }

        public class comparador : IComparer<int>
        {

            public int Compare(int x, int y)
            {
                return x.CompareTo(y);
            }

        }
    }


}

