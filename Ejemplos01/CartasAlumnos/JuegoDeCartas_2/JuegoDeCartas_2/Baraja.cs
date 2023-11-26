using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas_2
{
    internal class Baraja
    {
        public string[] palos;
        public int[] valores;
        public List<Carta> cartas;




        public Baraja(string[] palos, int[] valores)
        {
            this.palos = palos;
            this.valores = valores;
            this.cartas = new List<Carta>();
            crearBaraja();
            barajar();

        }


        public List<Carta> crearBaraja()
        {

            for (int i = 0; i < palos.Length; i++)
            {
                for (int j = 0; j < valores.Length; j++)
                {

                    cartas.Add( new Carta(valores[j], palos[i]));


                }
            }

            return cartas;

        }
        public List<Carta> barajar()
        {
            Random random = new Random();
            Carta aux;
            for (int i = 0; i < cartas.Count; i++)
            {
                int num = random.Next(cartas.Count - 1);
                aux = cartas[i];
                cartas[i] = cartas[num];
                cartas[num] = aux;
            }

            return cartas;
        }

        public Carta[] repartirCartas(int numcartas)
        {
            //to do: devolver n cartas de la baraja, dsp eliminar las cartas
            Carta[] cartasRepartir = new Carta[numcartas];

            for (int i = 0; i < numcartas; i++)
            {
                cartasRepartir[i] = cartas[i];
                cartas.RemoveAt(i);
            }

            Array.Sort(cartasRepartir, new comparador());
            Array.Reverse(cartasRepartir);
           
           
            return cartasRepartir;

        }

        public class comparador : IComparer<Carta>
        {
            public int Compare(Carta x, Carta y)
            {
                return x.valor.CompareTo(y.valor);
            }


        }
    }
    }


