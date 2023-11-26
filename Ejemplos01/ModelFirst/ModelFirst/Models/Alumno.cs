using System;
using System.Collections.Generic;

namespace ModelFirst.Models
{
    public partial class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; } = null!;
    }
}
