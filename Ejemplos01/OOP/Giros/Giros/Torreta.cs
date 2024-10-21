using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giros
{
    public class Torreta : IGiros
    {
        private ArrayList movimientos;
        public Torreta()
        {
            movimientos = new ArrayList();
        }
        public string girarDerecha()
        {
            movimientos.Add("D");
            return "Girando una torreta a la derecha";
        }

        public string girarIzquierda()
        {
            movimientos.Add("I");
            return "Girando una torreta a la izquierda";
        }
        public int posicion()
        {
            int pos = 0;
            foreach(string move in movimientos)
            {
                if (move == "D") { pos += 90; }
                if (move == "I") { pos -= 90; }
                 pos = (360 + pos) % 360;
            }
            return pos;
        }
         public int cuenta(string tipo)
        {
            var query = from string giro in movimientos
                        where giro==tipo
                        select giro;
            return query.Count();
        }
         public string listaMovimientos()
        {
            return String.Join(",", movimientos.ToArray());
        }
    }
}
