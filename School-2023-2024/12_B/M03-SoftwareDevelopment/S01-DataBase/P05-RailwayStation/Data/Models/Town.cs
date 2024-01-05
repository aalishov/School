using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data.Models
{
    public class Town
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<RailwayStation> RailwayStations { get; set; } = new List<RailwayStation>();

        [InverseProperty("DepartureTown")]
        public virtual ICollection<Train> DepartureTrains { get; set; } = new List<Train>();

        [InverseProperty("ArrivalTown")]
        public virtual ICollection<Train> ArrivalTrains { get; set; } = new List<Train>();
    }
}
