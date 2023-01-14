using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class User
{
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    public string Username { get; set; }
    [Required]
    [MaxLength(50)]
    public string Password { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public DateTime? Birthdate { get; set; }
    [Range(14, 110)]
    public int Age { get; set; }
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }

    public virtual ICollection<Report> Reports { get; set;} = new List<Report>();
}

