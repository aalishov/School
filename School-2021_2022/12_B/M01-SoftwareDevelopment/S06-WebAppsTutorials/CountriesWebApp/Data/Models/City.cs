using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesWebApp.Data.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PostCode { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
