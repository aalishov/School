using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Aircraft
{
    public int Id { get; set; }
    [MaxLength(25)]
    public string Manufacturer { get; set; }
    [MaxLength(30)]
    public string Model { get; set; }
    public int Year { get; set; }
    public int? FlightHours { get; set; }
    public char Condition { get; set; }
    public int TypeId { get; set; }

    public virtual ICollection<PilotAircraft> PilotAircrafts { get; set; } = new List<PilotAircraft>();
    public virtual ICollection<FlightDestination> FlightDestinations { get; set; } = new List<FlightDestination>();
}

