namespace MyApp.Console
{
    using MyApp.Services;
    using MyApp.ViewModels;
    using System;
    public class Program
    {
        private static CarsService cars = new CarsService();
        public static void Main()
        {

            while (true)
            {
                Console.Write("Enter cmd: ");
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "b":
                        Console.Write("Enter brand:");
                        string brand = Console.ReadLine();
                        List<IndexCarViewModel> list = cars.GetCarsByBrand(brand);
                        Console.WriteLine($"{brand} cars:");
                        foreach (var c in list)
                        {
                            Console.WriteLine($"\tModel: {c.Model}");
                        }
                        break;
                    case "e":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ivalid command!");
                        break;
                }
            }
        }


    }
}