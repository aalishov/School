using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OneToMany.Data.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer? Manufacturer { get; set; }
    }
}
