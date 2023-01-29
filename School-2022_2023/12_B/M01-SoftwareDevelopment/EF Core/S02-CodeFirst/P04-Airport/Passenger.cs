using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Passenger
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string FullName { get; set; }
    [MaxLength(50)]
    public string Email { get; set; }

    public virtual ICollection<FlightDestination> FlightDestinations { get; set; } = new List<FlightDestination>();
}

