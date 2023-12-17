using System;
using System.Collections.Generic;

namespace DBFirstTest.Models;

public partial class Curso
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public int Creditos { get; set; }
}
