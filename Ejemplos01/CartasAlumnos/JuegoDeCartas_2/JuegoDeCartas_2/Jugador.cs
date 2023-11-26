using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas_2
{
    internal class Jugador
    {
      
        private string nombre;
        private Carta[] misCartas;

       
        public Jugador(string nombre)
        {
            this.Nombre = nombre;

         
        }
        public Jugador() { }
   

        public string Nombre { get => nombre; set => nombre = value; }
        internal Carta[] MisCartas1 { get => misCartas; set => misCartas = value; }
        public override string ToString()
        {
            return $"Jugador  {nombre}";

        }

    }
}
