﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_v3
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string jugada { get; set; }

        private IJugada _ijugada;
     public Jugador(string nombre, IJugada ijugada)
        {
            this.Nombre = nombre;
            this._ijugada = ijugada;
        }
         public void pedirJugada(string[] validas)
        {
            this.jugada = _ijugada.pedirJugada(validas);
        }
        public override string ToString()
        {
            return this.Nombre + " - " + this.jugada;
        }
    }
}