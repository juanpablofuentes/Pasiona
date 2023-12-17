using System;
using System.Collections.Generic;

namespace DBFirstTest.Models;

public partial class Alumno
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Nota { get; set; }

    public DateTime? Inscripcion { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Falta> Falta { get; set; } = new List<Falta>();
}
