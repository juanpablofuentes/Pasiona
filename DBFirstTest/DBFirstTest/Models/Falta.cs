using System;
using System.Collections.Generic;

namespace DBFirstTest.Models;

public partial class Falta
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Comentario { get; set; }

    public int? Idalumno { get; set; }

    public virtual Alumno? IdalumnoNavigation { get; set; }
}
