using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data.Models
{
    public class MaintenanceRecord
    {
        public int Id { get; set; }

        public DateTime DateOfMaintenance { get; set; }

        [MaxLength(2000)]
        public string Details { get; set; }

        public int TrainId { get; set; }

        public virtual Train Train { get; set; }
    }
}
