using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class Report
{
    public int Id { get; set; }
    [Required]
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
    [Required]
    public int StatusId { get; set; }
    public virtual Status Status { get; set; }
    [Required]
    public DateTime OpenDate { get; set; }
    public DateTime? CloseDate { get; set; }
    [Required]
    [MaxLength(200)]
    public string Description { get; set; }
    [Required]
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public int? EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
   
    
}

