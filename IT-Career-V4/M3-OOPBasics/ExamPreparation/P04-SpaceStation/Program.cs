using System;

class Program
{
    static void Main()
    {
        Astronaut a1 = new Astronaut("Stephen", 40, "Bulgaria");
        Astronaut a2 = new Astronaut("Antonio", 35, "Spain");
        Astronaut a3 = new Astronaut("Mark", 39, "UK");
        Astronaut a4 = new Astronaut("Iuri", 43, "Russia");
        Astronaut a5 = new Astronaut("Alex", 41, "France");

        SpaceStation iss = new SpaceStation("ISS", 4);
        iss.Add(a1);
        iss.Add(a2);
        iss.Add(a3);
        iss.Add(a4);
        iss.Add(a5);

        Console.WriteLine(iss);
        Console.WriteLine(iss.GetOldestAstronaut());
    }
}

