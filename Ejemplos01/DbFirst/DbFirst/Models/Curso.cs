using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Curso
    {
        public Curso()
        {
            Alumnos = new HashSet<Alumno>();
            CursosAsignaturas = new HashSet<CursosAsignatura>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Creditos { get; set; }
        public int? ProfesorId { get; set; }

        public virtual Profesore? Profesor { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
        public virtual ICollection<CursosAsignatura> CursosAsignaturas { get; set; }
    }
}
