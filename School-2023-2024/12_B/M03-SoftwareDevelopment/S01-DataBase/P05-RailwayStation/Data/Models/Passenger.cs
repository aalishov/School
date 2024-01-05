using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
