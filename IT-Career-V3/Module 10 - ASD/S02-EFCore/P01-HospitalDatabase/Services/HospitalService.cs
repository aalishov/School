using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_HospitalDatabase.Services
{
    public class HospitalService
    {
        private readonly ApplicationDbContext dbContext;

        public HospitalService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddDoctor(string name, string specialty)
        {
            Doctor doctor = new Doctor()
            {
                Name = name,
                Specialty = specialty
            };
            dbContext.Doctors.Add(doctor);
            dbContext.SaveChanges();
        }
        public void AddMedicament(string name)
        {
            Medicament medicament = new Medicament()
            {
                Name = name
            };
            dbContext.Medicaments.Add(medicament);

            dbContext.SaveChanges();
        }
   
        public List<Doctor> GetAllDoctors()
        {
            return dbContext.Doctors.ToList();
        }

        public List<Medicament> GetAllMedicaments()
        {
            return dbContext.Medicaments.ToList();
        }


    }

}
