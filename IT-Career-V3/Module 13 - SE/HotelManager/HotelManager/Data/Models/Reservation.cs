using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Client> Clients { get; set; } = new HashSet<Client>();
        public DateTime StardDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public double TotalPrice { get; set; }
    }
}
