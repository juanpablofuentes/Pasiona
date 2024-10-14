using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSimplesC
{
    internal class Curso : ICurso
    {
        public List<String> Alumnos { get; set; }
        public void addAlumno(string nombre)
        {
            Alumnos.Add(nombre);
        }
    }
}
