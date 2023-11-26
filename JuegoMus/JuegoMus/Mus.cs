using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    public  class Mus
    {
       public Jugador[] Jugadores = new Jugador[4];
        Baraja Espanyola;

        public Mus(Jugador Jugador1, Jugador Jugador2, Jugador Jugador3, Jugador Jugador4)
        {
            Jugadores[0] = Jugador1;
            Jugadores[1] = Jugador2;
            Jugadores[2] = Jugador3;
            Jugadores[3] = Jugador4;
            Espanyola = new Baraja(new Espanyola());
            Espanyola.CrearMazo();
            Espanyola.Barajar();
            Repartir();
        }

        public void Repartir()
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (Jugador jugador in Jugadores)
                {
                    jugador.Mano.Add(Espanyola.Repartir());
                }
            }
        }

        public Jugador AGrande()
        {
            Comparador foo = new Comparador(NumGrande);
            List<Jugador> temp = Jugadores.ToList();

            temp.Sort(foo);
            return temp[0];
            }
        public Jugador APequenya()
        {
            Comparador foo = new Comparador(NumPequenya);
            List<Jugador> temp = Jugadores.ToList();

            temp.Sort(foo);
            return temp[0];
        }
        public Jugador APares()
        {
            Comparador foo = new Comparador(NumPares);
            List<Jugador> temp = Jugadores.ToList();

            temp.Sort(foo);
            return temp[0];
        
        }
    
        public Jugador AJuego()
        {
            Comparador foo = new Comparador(NumJuego);
            List<Jugador> temp = Jugadores.ToList();

            temp.Sort(foo);
            return temp[0];
        }
       
        private int NumGrande(int[] cartas)
        {
            double grande1 = 0;
            for (int i = 0; i < 4; i++)
            {
                grande1 += cartas[i] * Math.Pow(12, i);
            }
            return (int)grande1;
        }
      
        public int NumPequenya(int[] cartas)
        {
            double grande1 = 0;
            for (int i = 0; i < 4; i++)
            {
                grande1 += (13 - cartas[i]) * Math.Pow(12, 3 - i);
                
            }
            return (int)grande1;
        }
      
        public int NumPares(int[] cartas)
        {
            int res = 0;
            Array.Sort(cartas);
            var grupo = cartas.GroupBy(x => x);
            if (grupo.Count() == 3)
            {
                int cont = 1;
                foreach (var item in grupo)
                {
                    if (item.Count() > 1)
                    {
                        res += item.Key * 150;
                    }
                    else
                    {
                        res += item.Key * (cont * 12);
                        cont++;
                    }
                }
            }
            else if (grupo.Count() != 4 && grupo.Where(x => x.Count() == 3).Count() == 1)
            {
                foreach (var item in grupo)
                {
                    if (item.Count() > 1)
                    {
                        res += item.Key * 4000;
                    }
                    else
                    {
                        res += item.Key * 200;
                    }
                }
            }
            else if (grupo.Count() != 4 && grupo.Where(x => x.Count() == 2).Count() == 2)
            {

                res += grupo.First().Key * 24000;
                res += grupo.Last().Key * 464000;

            }
            return res;
        }
       
        public int NumJuego(int[] cartas)
        {
            int total = cartas.Sum(x=>x<10?x:10);
            int[] tabla = { 33, 34, 35, 36, 37, 40, 32, 31 };
            if (total <= 30)
            {
                return total;
            }
            else
            {
                return Array.IndexOf(tabla, total) + 31;
            }
        }
        public override string ToString()
        {
            return String.Join("\r\n", new List<Jugador>(Jugadores));
        }
    }
}
