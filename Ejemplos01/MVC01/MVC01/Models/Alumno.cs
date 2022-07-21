namespace MVC01.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public List<AlumnoCurso> Cursos { get; set; }
    }
}
