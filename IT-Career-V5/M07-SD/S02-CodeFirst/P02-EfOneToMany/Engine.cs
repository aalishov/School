namespace P02_EfOneToMany
{
    using Data;
    using Services;
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    public class Engine
    {
        private readonly AppService service;

        public Engine()
        {
            this.service = new AppService(new AppDbContext());
            Run();
        }
        public void Run()
        {
            RuningApp();
            while (true)
            {
                try
                {
                    Console.Write("Enter cmd: ");
                    string cmd = Console.ReadLine();

                    switch (cmd)
                    {
                        case "0":
                            Environment.Exit(0);
                            break;
                        case "1":
                            PrintModelsInfo();
                            break;
                        case "2":
                            AddManufacturer();
                            break;
                        case "3":
                            Console.Write("Enter manufacturer: ");
                            string manufacturer = Console.ReadLine();
                            Console.Write("Enter model: ");
                            string model = Console.ReadLine();
                            if (service.DoesManufacturerExist(manufacturer))
                            {
                                Console.WriteLine(service.AddModel(manufacturer, model));
                            }
                            else
                            {
                                Console.WriteLine("Manufacturer doesn't exist!");
                                Console.Write("Do you want to add manufacturer? Y/N: " );
                                bool doesHeWant = Console.ReadLine().ToLower() == "y" ? true : false;
                                if (doesHeWant)
                                {
                                    Console.Write("Enter established date:");
                                    DateTime establishedOn = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
                                    Console.WriteLine(service.AddManufacturer(manufacturer,establishedOn));
                                    Console.WriteLine(service.AddModel(manufacturer,model));
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid command!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void PrintModelsInfo()
        {
            Console.WriteLine("Models info:");
            Console.WriteLine(service.GetModelsInfo());
        }

        private void AddManufacturer()
        {
            Console.Write("Enter manufacturer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter establishe date:");
            DateTime establishedOn = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(service.AddManufacturer(name, establishedOn));
        }

        public void RuningApp()
        {
            Random random= new Random();
            string status = "";
           
            for (int i = 0; i <= 100; i+=random.Next(2,4))
            {
                status += " ";
                Console.WriteLine($"Loading {i} / 100%");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(status);
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(random.Next(100, 200));
                Console.Clear();
            }
        }
    }
}
