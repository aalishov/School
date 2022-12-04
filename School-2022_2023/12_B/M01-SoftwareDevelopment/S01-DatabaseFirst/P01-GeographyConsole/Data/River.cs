using System;
using System.Collections.Generic;

namespace P01_GeographyConsole.Data;

public partial class River
{
    public int Id { get; set; }

    public string RiverName { get; set; } = null!;

    public int Length { get; set; }

    public int DrainageArea { get; set; }

    public int AverageDischarge { get; set; }

    public string Outflow { get; set; } = null!;

    public virtual ICollection<Country> CountryCodes { get; } = new List<Country>();
}
