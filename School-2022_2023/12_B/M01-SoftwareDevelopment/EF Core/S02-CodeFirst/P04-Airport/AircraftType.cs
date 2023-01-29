using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AircraftType
{
    public int Id { get; set; }
    [MaxLength(30)]
    public string TypeName { get; set; }

    public virtual ICollection<Aircraft> Aircrafts { get; set; } = new List<Aircraft>();
}

