﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDatos
{
    internal class Producto
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; } = null!;
    }
}
