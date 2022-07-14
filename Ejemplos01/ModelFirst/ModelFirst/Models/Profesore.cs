using System;
using System.Collections.Generic;

namespace ModelFirst.Models
{
    public partial class Profesore
    {
        public Profesore()
        {
            Cursos = new HashSet<Curso>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Mail { get; set; } = null!;

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
