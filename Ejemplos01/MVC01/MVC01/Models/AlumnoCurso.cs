namespace MVC01.Models
{
    public class AlumnoCurso
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
    }
}
