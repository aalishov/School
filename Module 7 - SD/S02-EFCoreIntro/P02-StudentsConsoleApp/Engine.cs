namespace P02_StudentsConsoleApp
{
    using P02_StudentsServices;
    using System;
    using System.Text;

    public class Engine
    {
        private CountryService countryService;

        public Engine()
        {
            this.countryService = new CountryService();
        }
        public void Run()
        {
            while (true)
            {
                PrintMenu();

                string cmd = Console.ReadLine();
                string result = string.Empty;

                switch (cmd)
                {
                    case "1":
                        result = AddCountry();
                        break;
                    case "2":
                        result = countryService.GetAllCountries();
                        break;
                    case "3":
                        result = EditCountryName();
                        break;
                    default:
                        result = "Not supported command!";
                        break;
                }
                if (!string.IsNullOrWhiteSpace(result))
                {
                    Console.WriteLine(result);
                }
            }
        }

        private void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1: Add country");
            sb.AppendLine("2: Country list");
            sb.AppendLine("3: Change country name");
            sb.Append("Enter command: ");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        private string AddCountry()
        {
            Console.Write("Enter country name: ");
            string name = Console.ReadLine();
            return countryService.AddCountry(name);
        }

        private string EditCountryName()
        {
            Console.Write("Enter country id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter country new name: ");
            string newName = Console.ReadLine();
            return countryService.EditCoutryNameById(id,newName);
        }

    }
}
