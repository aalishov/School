
using RealEstates.Services;
using RealEstates.Services.Models;
using System;
using System.Text;

namespace RealEstates.ConsoleApp
{
    public class Engine
    {
        private readonly PropertiesService propertiesService;

        public Engine(PropertiesService propertiesService)
        {
            this.propertiesService = propertiesService;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(Menu());
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        ListOperations();
                        break;
                }
            }
        }

        public void ListOperations()
        {
            PropertiesViewModel model = propertiesService.GetProperties();
            while (true)
            {
                PrintLine();
                Console.WriteLine($"{"Цена",14} | {"Площ",4} | {"Етажи",5} | {"Местоположение"}");
                PrintLine();
                foreach (var property in model.Properties)
                {
                    Console.WriteLine($"{property.Price,10} лв. | {property.Size,4} | {property.Floor,5} | {property.District}");
                }
                PrintLine();
                Console.WriteLine($"Страница: {model.PageNumber} / {model.PagesCount}, Имоти: {model.ElementsCount}");
                PrintLine();
                Console.WriteLine(ListMenu());
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        Run();
                        break;
                    case "1":
                        if (model.HasPreviousPage)
                        {
                            model = propertiesService.GetProperties(model.PreviousPageNumber);
                        }
                        else
                        {
                            Console.WriteLine("Невалидна страница");
                        }
                        break;
                    case "2":
                        if (model.HasNextPage)
                        {
                            model = propertiesService.GetProperties(model.NextPageNumber);
                        }
                        else
                        {
                            Console.WriteLine("Невалидна страница");
                        }
                        break;
                }
            }
        }

        private static void PrintLine()
        {
            Console.WriteLine(new string('-', 70));
        }

        private string Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1: Списък с имоти");
            return sb.ToString().TrimEnd();
        }

        private string ListMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("0: Главно меню");
            sb.AppendLine("1: Предишна страница");
            sb.AppendLine("2: Следваща страница");
            return sb.ToString().TrimEnd();
        }
    }
}
