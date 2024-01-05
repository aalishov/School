using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime DateOfDeparture { get; set; }
        public DateTime DateOfArrival { get; set; }

        public int TrainId { get; set; }

        public virtual Train Train { get; set; }

        public int PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }

    }
}
