using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FlightDestination
{
    public int Id { get; set; }
    public int AirportId { get; set; }
    public DateTime Start { get; set; }
    public int AircraftId { get; set; }
    public int PassengerId { get; set; }
    [Precision(18,2)]
    public decimal TicketPrice { get; set; } = 15;
}

