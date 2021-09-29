using System;

namespace P01_StreetRacing
{
    class Program
    {
        static void Main()
        {
            Car car = new Car("BMW", "320ci", "NFS2005", 150, 1450);
            Car car1 = new Car("Audi", "A5", "NFS2009", 130, 1600);
            Car car2 = new Car("Audi", "A6", "NFS2007", 140, 1500);
            Car car3 = new Car("Opel", "Insignia", "NFS2008", 190, 1650);

            Race race = new Race("RockPort Race", "Sprint", 1, 4, 150);
            race.Add(car);
            race.Add(car1);
            race.Add(car2);
            Console.WriteLine(race.Remove("NFS2005"));
            Console.WriteLine(race.Report());
        }
    }
}
