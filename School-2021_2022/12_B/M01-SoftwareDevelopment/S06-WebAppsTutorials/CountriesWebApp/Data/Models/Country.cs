using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesWebApp.Data.Models
{
    public class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double? Area { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
