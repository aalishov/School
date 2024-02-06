using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OneToOne.Data.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        public double Salary { get; set; }

        public int PassportId { get; set; }

        public virtual Passport Passport { get; set; }
    }
}
