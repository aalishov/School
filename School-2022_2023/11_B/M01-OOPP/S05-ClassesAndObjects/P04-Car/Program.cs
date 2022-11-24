using System;

public class Program
{
    static void Main()
    {
        Engine m54b30 = new Engine(231, 2979);
        Tire t1 = new Tire(2022, 2.2);
        Tire t2 = new Tire(2022, 2.1);
        Tire t3 = new Tire(2019, 1.9);
        Tire t4 = new Tire(2019, 1.95);

        Tire[] tires = new Tire[] { t1, t2, t3, t4 };

        Car carn = new Car("BMW", "E60", 2005, 50, 13, m54b30, tires);


    }
}

