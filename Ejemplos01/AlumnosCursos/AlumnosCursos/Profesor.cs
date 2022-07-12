using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    internal class Profesor
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Mail { get; set; }
        List<Curso> Cursos { get; set; }
    }
}
