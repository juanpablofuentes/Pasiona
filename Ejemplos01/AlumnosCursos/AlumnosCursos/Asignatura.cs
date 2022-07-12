using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    internal class Asignatura
    {
        public Asignatura(string nombre, int horas)
        {
            Nombre = nombre;
            Horas = horas;
        }

        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Horas { get; set; }

        List<Curso_Asignatura> Cursos { get; set; }
    }
}
