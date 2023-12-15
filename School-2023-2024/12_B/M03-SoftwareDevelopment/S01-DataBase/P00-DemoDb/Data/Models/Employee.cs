using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoDb.Data.Models
{
    public class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public DateTime HireDate { get; set; }

        public double Salary { get; set; }
    }
}
