using System;
using System.Collections.Generic;

namespace DBFirstTest.Models;

public partial class City
{
    public int Id { get; set; }

    public string CityName { get; set; } = null!;

    public int CountryId { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Country Country { get; set; } = null!;
}
