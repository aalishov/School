using System;
using System.Collections.Generic;

namespace P01_GeographyConsole.Data;

public partial class Continent
{
    public string ContinentCode { get; set; } = null!;

    public string ContinentName { get; set; } = null!;

    public virtual ICollection<Country> Countries { get; } = new List<Country>();
}
