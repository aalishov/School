using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data.Models
{
    [PrimaryKey(nameof(TrainId), nameof(RailwayStationId))]
    public class TrainsRailwayStation
    {
        public int TrainId { get; set; }
        public virtual Train Train { get; set; }

        public int RailwayStationId { get; set; }
        public virtual RailwayStation RailwayStation { get; set; }
    }
}
