using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDatos
{
    public class Alumno
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
