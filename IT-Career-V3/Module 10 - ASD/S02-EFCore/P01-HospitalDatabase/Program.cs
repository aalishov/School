using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Data.Models;
using P01_HospitalDatabase.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_HospitalDatabase
{
    public class Program
    {
        private static ApplicationDbContext dbContext = new ApplicationDbContext();
        private static HospitalService service = new HospitalService(dbContext);
        static void Main()
        {
            Run();
        }

        public static void Run()
        {
            while (true)
            {
                PrintMainMenu();
                string cmd = Console.ReadLine();
                if (cmd=="end")
                {
                    break;
                }
                switch (cmd)
                {
                    case "1":
                        PrintAddMenu();
                        string addCmd = Console.ReadLine();
                        switch (addCmd)
                        {
                            case"1.1":
                                AddDoctor();
                                break;
                            default:
                                Console.WriteLine("Няма такава команда!");
                                break;
                        }
                        break;
                    case "2":
                        PrintGetMenu();
                        string getCmd = Console.ReadLine();
                        switch (getCmd)
                        {
                            case "2.1":
                                PrintAllDoctors();
                                break;
                            default:
                                Console.WriteLine("Няма такава команда!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Няма такава команда!");
                        break;
                }
                Console.WriteLine(new string('*',20));
            }
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine($"1. Добавяне");
            Console.WriteLine($"2. Информация");
        }
        public static void PrintAddMenu()
        {
            Console.WriteLine($"1.1 Добавяне на лекар");
            Console.WriteLine($"1.2 Добавяне на лекарство");
        }
        public static void PrintGetMenu()
        {
            Console.WriteLine($"2.1 Списък с лекари");
            Console.WriteLine($"2.2 Списък с лекарства");
        }
        public static void AddDoctor()
        {
            Console.Write("Въведи име: ");
            string name = Console.ReadLine();
            Console.Write("Въведи специалност: ");
            string specialty = Console.ReadLine();
            service.AddDoctor(name, specialty);
            Console.WriteLine($"=> Др. {name} е добавен!");
        }
        public static void PrintAllDoctors()
        {
            List<Doctor> doctors = service.GetAllDoctors();
            Console.WriteLine($"{"Ид.",-3} {"Име",-8} - {"Специалност",-12}");
            foreach (var d in doctors)
            {
                Console.WriteLine($"{d.DoctorId,-3} {d.Name,-8} - {d.Specialty,-12}");
            }
        }
    }
}
