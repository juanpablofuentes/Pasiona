using System;
using System.Collections.Generic;

namespace ModelFirst.Models
{
    public partial class CursosAsignatura
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public int AsignaturaId { get; set; }

        public virtual Asignatura Asignatura { get; set; } = null!;
        public virtual Curso Curso { get; set; } = null!;
    }
}
