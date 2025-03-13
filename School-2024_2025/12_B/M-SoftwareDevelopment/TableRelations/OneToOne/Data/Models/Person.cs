using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Data.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public virtual Passport Passport { get; set; }

        public int PassportId { get; set; }
    }
}
