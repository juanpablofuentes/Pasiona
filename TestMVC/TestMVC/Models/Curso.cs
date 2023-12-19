using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
    }
}
