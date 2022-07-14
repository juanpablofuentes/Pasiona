using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeCartas3
{
    internal class Jugador
    {
        private Carta[] _mano = new Carta[4];

        public string Nombre { get; set; }
        public Carta[] VerMano { get { return _mano; } }

        public Jugador(string nombre)       
        {
            Nombre = nombre;
        }

        public Carta[] Mano(Carta carta)
        {
            for (int i = 0; i < _mano.Length; i++)
            {
                if (_mano[i] == null)
                {
                    _mano[i] = carta;
                    break;
                }
            }

            return _mano;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
