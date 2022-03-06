namespace Scooters.Services
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RentsService
    {
        private readonly AppDbContext context;
        private readonly UsersService users;
        private readonly ScootersService scooters;

        private const decimal PricePerDay = 5;
        public RentsService(AppDbContext context, UsersService users, ScootersService scooters)
        {
            this.context = context;
            this.users = users;
            this.scooters = scooters;
        }

        public void Complete(int rentId, string username)
        {
            Rent rent = GetRentById(rentId);
            if (rent == null || rent.User.Username != username)
            {
                throw new ArgumentException("Rent not found!");
            }
            if (rent.IsComleted)
            {
                throw new ArgumentException("Rent already payed!");
            }
            rent.EndDate = DateTime.UtcNow;
            int days = (DateTime.UtcNow - rent.StartDate).Days;
            days = days == 0 ? 1 : days;
            decimal price = days * PricePerDay;
            rent.User.Balance -= price;
            rent.IsComleted = true;
            rent.Scooter.IsTaken = false;
            context.Rents.Update(rent);
            context.SaveChanges();
        }

        public void Rent(int userId, int scooterId)
        {
            User user = users.GetUserById(userId);
            Scooter scooter = scooters.GetScooterById(scooterId);
            if (user == null || scooter == null)
            {
                throw new ArgumentException("User or scooter not found!");
            }
            int userRents = user.Rents.Count(x => x.IsComleted == false);
            if (userRents>=5)
            {
                throw new ArgumentException("Too many rented scooters!");
            }
            if (user.Balance < PricePerDay)
            {
                throw new ArgumentException("Insufficient balance!");
            }
            if (scooter.IsTaken)
            {
                throw new ArgumentException("Scootre not available!");
            }
            Rent rent = new Rent()
            {
                User = user,
                Scooter = scooter,
                StartDate = DateTime.UtcNow,
            };
            scooter.IsTaken = true;

            context.Scooters.Update(scooter);
            context.Rents.Add(rent);
            context.SaveChanges();
        }

        public Rent GetRentById(int id)
        {
            return this.context.Rents.Find(id);
        }
        public ICollection<Rent> GetActiveRents()
        {
            return this.context.Rents
                .Where(x => x.IsComleted == false)
                .OrderByDescending(x => x.StartDate)
                .ToList();
        }

        public ICollection<Rent> GetRentsByUsername(string username)
        {
            return this.context.Rents
                .Where(x => x.User.Username == username && x.IsComleted == false)
                .ToList();
        }
        public ICollection<Rent> GetRentsHistoryByUsername(string username)
        {
            return this.context.Rents
                .Where(x => x.User.Username == username && x.IsComleted == true)
                .ToList();
        }
    }
}
