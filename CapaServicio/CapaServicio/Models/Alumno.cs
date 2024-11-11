using System.ComponentModel.DataAnnotations;

namespace CapaServicio.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [MaxLength(10), MinLength(5)]
        public String Nombre { get; set; }
        public int Nota { get; set; }

        
    }
}
