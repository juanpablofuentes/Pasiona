namespace MVC01.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        List<AlumnoCurso> Alumnos { get; set; }
    }
}
