using System;
using System.Collections.Generic;

namespace P02_Geography.Data.Models;

public partial class Continent
{
    public string ContinentCode { get; set; } = null!;

    public string ContinentName { get; set; } = null!;

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
