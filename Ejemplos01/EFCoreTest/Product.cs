﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

      
}
}
