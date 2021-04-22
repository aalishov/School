using System;

namespace P05_CarManufacturer
{
    class Program
    {
        static void Main()
        {
            Car c = new Car()
            {
                Make = "Audi",
                Model = "A6",
                Year = 2010
            };
            Console.WriteLine(c.Make);
        }
    }
}
