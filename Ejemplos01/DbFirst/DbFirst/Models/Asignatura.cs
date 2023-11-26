using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Asignatura
    {
        public Asignatura()
        {
            CursosAsignaturas = new HashSet<CursosAsignatura>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Tiempo { get; set; }

        public virtual ICollection<CursosAsignatura> CursosAsignaturas { get; set; }
    }
}
