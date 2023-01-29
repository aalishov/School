using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Airport
{
    public int Id { get; set; }
    [MaxLength(70)]
    public string AirportName { get; set; }
    [MaxLength(100)]
    public string Country { get; set; }

    public virtual ICollection<FlightDestination> FlightDestinations { get; set; } = new List<FlightDestination>();

}

