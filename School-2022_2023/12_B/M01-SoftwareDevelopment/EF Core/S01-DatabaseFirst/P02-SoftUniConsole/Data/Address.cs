using System;
using System.Collections.Generic;

namespace P02_SoftUniConsole.Data;

public partial class Address
{
    public int AddressId { get; set; }

    public string AddressText { get; set; } = null!;

    public int? TownId { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual Town? Town { get; set; }
}
