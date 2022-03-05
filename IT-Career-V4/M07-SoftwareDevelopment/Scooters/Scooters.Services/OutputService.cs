namespace Scooters.Services
{
    using Scooters.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OutputService
    {

        public string PrintUsers(ICollection<User> users, string message = null)
        {
            StringBuilder sb = new StringBuilder();
            AddTableTitle(message, sb);
            string header=$"|{"Id",-5} | {"Name",-25} | {"Balance",-8} | {"City",-18} | {"Register date",-15}|";
            sb.AppendLine(header);
            sb.AppendLine(Border(header.Length));
            foreach (var user in users)
            {
                string name = $"{user.FirstName} {user.LastName}";
                sb.AppendLine($"|{user.Id,-5} | {name,-25} | {Math.Round(user.Balance, 3),-8} | {user.City.Name,-18} | {user.RegisterDate.ToShortDateString(),-15}|");
                sb.AppendLine(Border(header.Length));
            }
            return sb.ToString().TrimEnd();
        }
        public string PrintScooters(ICollection<Scooter> scooters, string message = null)
        {
            StringBuilder sb = new StringBuilder();
            AddTableTitle(message, sb);
            string header = $"|{"Id",-5} | {"Model",-8} | {"Taken",-6}|";
            sb.AppendLine(header);
            sb.AppendLine(Border(header.Length));
            foreach (var scooter in scooters)
            {
                string taken = scooter.IsTaken ? "Yes" : "No";
                sb.AppendLine($"|{scooter.Id,-5} | {scooter.Model,-8} | {taken,-6}|");
                sb.AppendLine(Border(header.Length));
            }
            return sb.ToString().TrimEnd();
        }
        public string PrintRents(ICollection<Rent> rents, string message = null)
        {
            StringBuilder sb = new StringBuilder();
            AddTableTitle(message, sb);
            string header = $"|{"Id",-5} | {"Username",-10} | {"Model",-8} | {"Start",-15} | {"End",-15} | {"Completed",-10}|";
            sb.AppendLine(header);

            sb.AppendLine(Border(header.Length));
            foreach (var rent in rents)
            {
                string end = rent.EndDate != null ? ((DateTime)rent.EndDate).ToShortDateString() : "n/a";
                string completed = rent.IsComleted == true ? "Yes" : "No";
                string username = rent.User.Username.Length > 10 ? rent.User.Username.Substring(0, 10) : rent.User.Username;
                sb.AppendLine($"|{rent.Id,-5} | {username,-10} | {rent.Scooter.Model,-8} | {rent.StartDate.ToShortDateString(),-15} | {end,-15} | {completed,-10}|");
                sb.AppendLine(Border(header.Length));
            }
            return sb.ToString().TrimEnd();
        }
        private static string Border(int size)
        {
            return $"|{new string('-', size - 2)}|";
        }
        private static void AddTableTitle(string message, StringBuilder sb)
        {
            if (message != null)
            {
                sb.AppendLine($"-- {message} --");
            }
        }

    }
}
