using System;
using System.Collections.Generic;

namespace P01_Airport.Data;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string JobTitle { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int? ManagerId { get; set; }

    public DateTime HireDate { get; set; }

    public decimal Salary { get; set; }

    public int? AddressId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; } = new List<Department>();

    public virtual ICollection<Employee> InverseManager { get; } = new List<Employee>();

    public virtual Employee? Manager { get; set; }

    public virtual ICollection<Project> Projects { get; } = new List<Project>();
}
