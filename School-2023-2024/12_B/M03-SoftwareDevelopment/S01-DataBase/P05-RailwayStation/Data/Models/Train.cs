using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data.Models
{
    public class Train
    {
        public int Id { get; set; }

        public DateTime HourOfDeparture { get; set; }

        public DateTime HourOfArrival { get; set; }

        public int DepartureTownId { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Town DepartureTown { get; set; }
        public int ArrivalTownId { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Town ArrivalTown { get; set; }

        public virtual ICollection<TrainsRailwayStation> TrainsRailwayStations { get; set; } = new List<TrainsRailwayStation>();

        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
