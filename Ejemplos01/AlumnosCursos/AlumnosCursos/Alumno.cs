using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    internal class Alumno
    {
        public Alumno()
        {
        }

        public Alumno(string nombre, string dNI, string mail, Curso curso)
        {
            Nombre = nombre;
            DNI = dNI;
            Mail = mail;
            Curso = curso;
        }

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String DNI { get; set; }
        public String Mail { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
