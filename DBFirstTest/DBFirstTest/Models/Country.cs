using System;
using System.Collections.Generic;

namespace DBFirstTest.Models;

public partial class Country
{
    public int Id { get; set; }

    public string CountryName { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
