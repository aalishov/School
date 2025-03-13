using System;
using System.Collections.Generic;

namespace P02_Geography.Data.Models;

public partial class Mountain
{
    public int Id { get; set; }

    public string MountainRange { get; set; } = null!;

    public virtual ICollection<Peak> Peaks { get; set; } = new List<Peak>();

    public virtual ICollection<Country> CountryCodes { get; set; } = new List<Country>();
}
