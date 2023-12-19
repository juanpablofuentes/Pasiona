using System;
using System.Collections.Generic;

namespace DBFirstTest.Models;

public partial class Profesore
{
    public int Id { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string Email { get; set; } = null!;
}
