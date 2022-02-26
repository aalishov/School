namespace Scooters.ConsoleApp
{
    using Scooters.Models;
    using Scooters.Services;
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            MainService service = new MainService();

            ICollection<User> users = service.UsersService.GetAllUsersRegisteredAfterDate("01/01/2021");
            PrintUsers(users);
        }
        public static void PrintUsers(ICollection<User> users)
        {
            Console.WriteLine($"|{"Id",5} | {"Name",-25} | {"Balance",-8} | {"City",-18} | {"Register date",-15}|");
            Console.WriteLine($"| {new string('-', 81)} |");
            foreach (var user in users)
            {
                string name = $"{user.FirstName} {user.LastName}";
                Console.WriteLine($"|{user.Id,5} | {name,-25} | {Math.Round(user.Balance,3),-8} | {user.City.Name,-18} | {user.RegisterDate.ToShortDateString(),-15}|");
                Console.WriteLine($"| {new string('-',81)} |");
            }
        }
    }
}
