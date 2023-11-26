using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AlumnosCursos
{
    [Table("cursoas")]
    [Keyless]
    [NotMapped]
    internal class CursoAsig
    {
        public String Nombre { get; set; }
        public String Asignatura { get; set; }
        public override string ToString()
        {
            return Nombre+" | "+Asignatura;
        }
    }
}
