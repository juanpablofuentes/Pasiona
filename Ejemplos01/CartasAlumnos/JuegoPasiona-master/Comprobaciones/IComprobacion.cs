﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jugadores;

namespace Comprobaciones
{
    internal interface IComprobacion
    {
        public string[] ganadores(List<Jugador> jugadores);
    }
}
