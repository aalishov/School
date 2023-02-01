using System;
using System.Collections.Generic;

namespace P01_Airport.Data;

public partial class Town
{
    public int TownId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
