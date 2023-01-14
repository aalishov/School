using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class Status
{
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    public string Label { get; set; }
    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}

