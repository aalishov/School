using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class Category
{
    public int ID { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; }
    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}

