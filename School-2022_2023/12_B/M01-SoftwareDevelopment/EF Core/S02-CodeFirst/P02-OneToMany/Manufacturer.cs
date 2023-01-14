using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Manufacturer
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public DateTime EstablishedOn { get; set; }
    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}

