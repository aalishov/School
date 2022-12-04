using System;
using System.Collections.Generic;

namespace P01_GeographyConsole.Data;

public partial class Currency
{
    public string CurrencyCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Country> Countries { get; } = new List<Country>();
}
