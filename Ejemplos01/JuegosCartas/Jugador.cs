using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosCartas
{
    internal class Jugador
    {
        public Jugador(string nombre)
        {
            Nombre = nombre;
            Mano=new List<Carta>();
        }

        public string Nombre { get; set; }
        public List<Carta> Mano { get; set; }

        public override string ToString()
        {
            return Nombre+" Mano: "+String.Join(",",Mano.OrderBy(o => o.Valor).ToList());
        }
    }
}
