namespace Scooters.Services
{
    using Data;
    using System;
    using Scooters.Models;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class UsersService
    {
        private readonly AppDbContext context;
        public UsersService(AppDbContext context)
        {
            this.context = context;
        }
        public ICollection<string> GetAllCitiesName()
        {
            return this.context.Cities
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();
        }
        public int GetUsersCount()
        {
            return context.Users.Count();
        }
        public void Deposit(string username, string value)
        {
            User user = GetUserByUsername(username);
            if (!decimal.TryParse(value, out _) || user == null || decimal.Parse(value) <= 0)
            {
                throw new ArgumentException("Invalid operation!");
            }
            user.Balance += decimal.Parse(value);
            context.Users.Update(user);
            context.SaveChanges();
        }
        public int GetUserIdByUsername(string username)
        {
            return this.context.Users
                .FirstOrDefault(x => x.Username == username).Id;
        }
        public decimal GetUserBalance(string username)
        {
            return this.context.Users.FirstOrDefault(x => x.Username == username).Balance;
        }
        public bool Login(string username, string password)
        {
            User user = GetUserByUsername(username);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }
            if (user.Password == password)
            {
                return true;
            }
            return false;
        }
        public User GetUserByUsername(string username)
        {
            return this.context.Users.FirstOrDefault(x => x.Username == username);
        }
        public ICollection<User> GetUsers(int page = 1, int itemsPerPage = 10)
        {
            return this.context.Users
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();
        }
        public User GetUserById(int id)
        {
            return this.context.Users.Find(id);
        }
        public ICollection<User> GetUsersByCity(string cityName)
        {
            return this.context.Users
                .OrderBy(x => x.City.Name)
                .ToList()
                .Where(x => x.City.Name.StartsWith(cityName, true, CultureInfo.InvariantCulture))
                .ToList();
        }
        public ICollection<User> GetAllUsersWithNoBalance()
        {
            return this.context.Users.Where(x => x.Balance == 0).ToList();
        }
        public ICollection<User> GetAllUsersRegisteredAfterDate(string date)
        {
            DateTime searchDate = DateTime.Now;
            if (!DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchDate))
            {
                throw new ArgumentException("Invalid date!");
            }
            return this.context.Users
                .Where(x => x.RegisterDate >= searchDate)
                .OrderByDescending(x => x.RegisterDate)
                .ToList();
        }
        public void CreateUser(string username, string password, string firstName, string lastName, string balance, string city)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                !decimal.TryParse(balance, out _) ||
                string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("Invalid user data!");
            }
            City userCity = context.Cities.FirstOrDefault(x => x.Name == city);
            if (userCity == null)
            {
                userCity = new City() { Name = city };
            }
            decimal userBalance = decimal.Parse(balance);
            User user = new User()
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Balance = userBalance,
                City = userCity,
                RegisterDate = DateTime.UtcNow
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void ChangeName(int id, string firstName, string lastName)
        {
            User user = GetUserById(id);
            if (user == null)
            {
                throw new ArgumentException("User not found!");
            }
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Invalid user data!");
            }
            user.FirstName = firstName;
            user.LastName = lastName;
            context.Users.Update(user);
            context.SaveChanges();
        }
        public void DeleteUserById(int id)
        {
            User user = GetUserById(id);
            if (user == null)
            {
                throw new ArgumentException("Usern not found!");
            }
            context.Users.Remove(user);
            context.SaveChanges();
        }

    }
}
