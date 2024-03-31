using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Data.Models
{
    public class Review
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public string Description { get; set; }

        public double Rating { get; set; }
    }
}
