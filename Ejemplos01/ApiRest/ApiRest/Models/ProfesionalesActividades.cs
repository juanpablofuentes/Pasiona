namespace Profesiones.Models
{
    public class ProfesionalesActividades
    {
        public int Id { get; set; }
        public int ProfesionalId { get; set; }
        public Profesional? Profesional { get; set; }
        public int ActividadId { get; set; }
        public Actividad? Actividad { get; set; }

        public int Precio { get; set; }
    }
}
