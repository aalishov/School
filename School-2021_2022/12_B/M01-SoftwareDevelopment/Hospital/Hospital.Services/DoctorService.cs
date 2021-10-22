using Hospital.Data;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Services
{
    public  class DoctorService
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public void Add(string name, string position)
        {
            dbContext.doctors.Add(new Doctor(name, position));
        }

        public List<string>DoctorsNames()
        {
            return dbContext.doctors.Select(x => x.Name).ToList();
        }
    }
}
