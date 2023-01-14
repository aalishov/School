using System;
using System.Collections.Generic;

namespace P01_GeographyConsole.Data;

public partial class Mountain
{
    public int Id { get; set; }

    public string MountainRange { get; set; } = null!;

    public virtual ICollection<Peak> Peaks { get; } = new List<Peak>();

    public virtual ICollection<Country> CountryCodes { get; } = new List<Country>();
}
