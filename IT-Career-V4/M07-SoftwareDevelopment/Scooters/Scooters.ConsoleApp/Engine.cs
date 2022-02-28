namespace Scooters.ConsoleApp
{
    using Scooters.Models;
    using Scooters.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public class Engine
    {
        private MainService main;
        private OutputService output;
        private static bool isLogged = false;
        private static string appUser = null;
        public Engine()
        {
            main = new MainService();
            output = new OutputService();
            Run();
        }

        public void Run()
        {
            Console.Write("App running");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Clear();
            while (true)
            {
                try
                {
                    if (appUser == "admin" && isLogged)
                    {
                        AdminPage();
                    }
                    else if (isLogged)
                    {
                        UserPage();
                    }
                    else
                    {
                        LoginOrRegister();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        public void AdminPage()
        {
            while (true)
            {
                try
                {
                    if (!isLogged)
                    {
                        break;
                    }
                    Console.Write("Select U (App users), L (Logout): ");
                    string option = Console.ReadLine().ToUpper();
                    switch (option)
                    {
                        case "R":
                            break;
                        case "P":
                            break;
                        case "U":
                            UserList();
                            break;
                        case "H":
                            break;
                        case "L":
                            LogOut();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void UserList()
        {
            int page = 1;
            int totalPage = (int)Math.Ceiling(main.Users.GetUsersCount() / 10.0);
            while (true)
            {
                string users = output.PrintUsers(main.Users.GetUsers(page), $"User list - page {page} / {totalPage} ");
                Console.WriteLine(users);
                Console.WriteLine("P (Previous page), N (Next page), B (back)");
                string option = ReadInput("Select option: ").ToUpper();
                switch (option)
                {
                    case "P":
                        if (page > 1)
                        {
                            page--;
                        }
                        break;
                    case "N":
                        if (page < totalPage)
                        {
                            page++;
                        }
                        break;
                }
                if (option == "B")
                {
                    break;
                }
            }

        }
        public void UserPage()
        {
            while (true)
            {
                try
                {
                    if (!isLogged)
                    {
                        break;
                    }
                    Console.Write("Select R (Rent), P (Pay rent), U (User info), H (Rent history), L (Logout): ");
                    string option = Console.ReadLine().ToUpper();
                    switch (option)
                    {
                        case "R":
                            UserRent();
                            break;
                        case "P":
                            PayRent();
                            break;
                        case "U":
                            UserInfo();
                            break;
                        case "H":
                            UserHistoryInfo();
                            break;
                        case "L":
                            LogOut();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void PayRent()
        {
            UserInfo();
            int rentId = int.Parse(ReadInput("Enter rent id: "));
            main.Rents.Complete(rentId, appUser);
            Console.WriteLine($"Payment complete!");
            Console.WriteLine($" Your balance: {main.Users.GetUserBalance(appUser)}");
        }
        public void LogOut()
        {
            isLogged = false;
            appUser = null;
        }
        public void UserRent()
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Scooter> scooters = main.Scooters.GetFreeScooters();
            sb.AppendLine(output.PrintScooters(scooters, "Free scoouters"));
            Console.WriteLine(sb.ToString().TrimEnd());
            int scoouterId = int.Parse(ReadInput("Enter scooter id: "));
            int userId = main.Users.GetUserIdByUsername(appUser);
            main.Rents.Rent(userId, scoouterId);
            Console.WriteLine("You rent a scooter!");
        }
        public void UserHistoryInfo()
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Rent> rents = main.Rents.GetRentsHistoryByUsername(appUser);
            if (rents.Any())
            {
                sb.AppendLine(output.PrintRents(rents, "Your rents history"));
            }
            else
            {
                sb.AppendLine("No active rents");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public void UserInfo()
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Rent> rents = main.Rents.GetRentsByUsername(appUser);
            if (rents.Any())
            {
                sb.AppendLine(output.PrintRents(rents, "Your rents"));
            }
            else
            {
                sb.AppendLine("No active rents");
            }
            sb.AppendLine($"Balance: {main.Users.GetUserBalance(appUser)}");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public void LoginOrRegister()
        {
            while (true)
            {
                if (isLogged)
                {
                    break;
                }
                Console.Write("Select L (Login) or R (Register), E(Exit): ");
                string option = Console.ReadLine().ToUpper();
                switch (option)
                {
                    case "L":
                        LoginPage();
                        break;
                    case "R":
                        RegisterPage();
                        break;
                    case "E":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        public void RegisterPage()
        {
            Console.WriteLine($"-- Register page --");
            try
            {
                string username = ReadInput("Enter username: ");
                string password = ReadInput("Enter password: ");
                string firstName = ReadInput("Enter first name: ");
                string lastName = ReadInput("Enter last name: ");
                string balance = ReadInput("Enter initial balance: ");
                string city = ReadInput("Enter city: ");
                main.Users.CreateUser(username, password, firstName, lastName, balance, city);
                appUser = username;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Succesfully registered!");
        }
        private string ReadInput(string message)
        {
            Console.Write($">{message}");
            return Console.ReadLine();
        }
        private void LoginPage()
        {
            Console.WriteLine($"-- Login page --");

            while (!isLogged)
            {
                try
                {
                    Console.Write(">Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write(">Enter password: ");
                    string password = Console.ReadLine();
                    if (main.Users.Login(username, password))
                    {
                        isLogged = true;
                        appUser = username;
                        Console.Clear();
                        Console.WriteLine($"User: {username}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (!isLogged)
                {
                    Console.WriteLine("Invalid username or password! Try agin!");
                }
            }
        }
    }
}
