using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    internal class Curso_Asignatura
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
