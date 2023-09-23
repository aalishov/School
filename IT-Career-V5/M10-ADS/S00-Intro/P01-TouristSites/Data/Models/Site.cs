using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_TouristSites.Data.Models
{
    public class Site
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string? Establishment { get; set; }

        public virtual ICollection<SiteTourist> SitesTourists { get; set; } = new List<SiteTourist>();

    }
}
