using System;
using System.Collections.Generic;

namespace P02_Geography.Data.Models;

public partial class River
{
    public int Id { get; set; }

    public string RiverName { get; set; } = null!;

    public int Length { get; set; }

    public int DrainageArea { get; set; }

    public int AverageDischarge { get; set; }

    public string Outflow { get; set; } = null!;

    public virtual ICollection<Country> CountryCodes { get; set; } = new List<Country>();
}
