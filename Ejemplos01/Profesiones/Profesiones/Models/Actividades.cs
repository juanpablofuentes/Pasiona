namespace Profesiones.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public List<ProfesionalesActividades> Profesionales { get; set; } = new List<ProfesionalesActividades>();
    }
}
