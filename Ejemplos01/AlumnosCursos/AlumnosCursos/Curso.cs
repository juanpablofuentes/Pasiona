using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    internal class Curso
    {
        public Curso(string nombre, int creditos)
        {
            Nombre = nombre;
            Creditos = creditos;
        }

        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Creditos { get; set; }
        public List<Alumno>? Alumnos { get; set; }
    }
}
