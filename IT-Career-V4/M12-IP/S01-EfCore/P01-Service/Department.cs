using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class Department
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public virtual ICollection<Category> Categories { get;set; }= new List<Category>();
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}

