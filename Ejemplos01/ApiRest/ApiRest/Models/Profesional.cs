namespace Profesiones.Models
{
    public class Profesional
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Mail { get; set; }
        public bool Activo { get; set; }
        public List<ProfesionalesActividades> Actividades { get; set; } = new List<ProfesionalesActividades>();

    }
}
