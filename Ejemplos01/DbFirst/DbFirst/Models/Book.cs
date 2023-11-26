using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
