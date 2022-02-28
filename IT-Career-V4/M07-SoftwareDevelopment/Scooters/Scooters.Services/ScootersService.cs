namespace Scooters.Services
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ScootersService
    {
        private readonly AppDbContext context;

        public ScootersService(AppDbContext context)
        {
            this.context = context;
        }
        public Scooter GetScooterById(int id)
        {
            return this.context.Scooters.Find(id);
        }
        public bool CheckTakenById(int id)
        {
            Scooter scooter = GetScooterById(id);
            if (scooter==null)
            {
                throw new ArgumentException("Scooter not found!");
            }
            return scooter.IsTaken;
        }
        public ICollection<Scooter> GetFreeScooters(int page=1,int itemsPerPage=5)
        {
            return context.Scooters
                .Where(x => x.IsTaken == false)
                .Skip((page-1)*itemsPerPage)
                .Take(itemsPerPage)
                .ToList();
        }
        public ICollection<Scooter> GetTakenScooters()
        {
            return context.Scooters
                .Where(x => x.IsTaken == true)
                .ToList();
        }
    }
}
