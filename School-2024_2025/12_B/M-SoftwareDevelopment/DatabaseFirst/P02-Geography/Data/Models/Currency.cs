using System;
using System.Collections.Generic;

namespace P02_Geography.Data.Models;

public partial class Currency
{
    public string CurrencyCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
