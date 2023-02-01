using System;
using System.Collections.Generic;

namespace P01_Airport.Data;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public int ManagerId { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual Employee Manager { get; set; } = null!;
}
