using System;
using System.Collections.Generic;

namespace P05_CarManufacturer
{
    class Program
    {
        static void Main()
        {
            Engine engine = new Engine(150, 2000);
            Tire tire1 = new Tire(2.2, 2018);
            Tire tire2 = new Tire(2.2, 2018);
            Tire tire3 = new Tire(2.4, 2020);
            Tire tire4 = new Tire(2.4, 2020);
            List<Tire> tires = new List<Tire>() { tire1, tire2, tire3, tire4 };

            Car c = new Car("Audi","A6",2010,50,0.1,tires,engine);

            Console.WriteLine(c.Drive(100));
            Console.WriteLine(c.Drive(50));
            Console.WriteLine(c.Drive(100));
            Console.WriteLine(c.Drive(300));
            Console.WriteLine(c);
        }
    }
}
