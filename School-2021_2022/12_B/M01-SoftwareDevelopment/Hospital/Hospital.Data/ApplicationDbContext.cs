using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext()
        {
            this.doctors = new List<Doctor>() { new Doctor("Petrov", "Surgery"), new Doctor("Ivanov", "Surgery"), new Doctor("Nikolov", "Surgery") };
        }
        public List<Doctor> doctors { get; set; }
    }
}
