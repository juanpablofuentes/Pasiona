using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursos
{
    [Table("Books", Schema="test")]
    internal class Book
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
    }
}
