using BrokerCompany.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrokerCompany.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            CompanyController controller = new CompanyController();
            Console.WriteLine(controller.CreateCompany(new List<string>() { "Lidl" }));
            Console.WriteLine(controller.CreateCompany(new List<string>() { "Lidl" }));
            Console.WriteLine(controller.RegisterBuilding(new List<string>() { "Business", "Billa Velingrad", "Velingrad", "5", "5000", "Billa" }));
            Console.WriteLine(controller.RegisterBuilding(new List<string>() { "Business", "Lidl Velingrad", "Velingrad", "5", "5000", "Lidl" }));
            Console.WriteLine(controller.RegisterBuilding(new List<string>() { "Business", "Lidl Velingrad", "Velingrad", "5", "5000", "Lidl" }));
        }
    }
}

