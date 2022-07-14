using System;
using System.Collections.Generic;

namespace ModelFirst.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
