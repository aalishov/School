using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P02_StudentsAppData.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        
        public int SchoolId { get; set; }

        public virtual School School { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
