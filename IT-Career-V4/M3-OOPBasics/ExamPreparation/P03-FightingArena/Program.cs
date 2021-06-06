using System;

class Program
{
    static void Main()
    {
        Gladiator g1 = new Gladiator("John",new Stat(50,25,45,45,30),new Weapon(0,0,32));
        Gladiator g2 = new Gladiator("Alex", new Stat(50, 30, 45, 35, 25), new Weapon(40, 22, 32));
        Gladiator g3 = new Gladiator("Adam", new Stat(40, 38, 45, 45, 25), new Weapon(30, 26, 12));

        Arena arena = new Arena("Armeec");
        arena.Add(g1);
        arena.Add(g2);
        arena.Add(g3);

        Console.WriteLine(arena.Count);
        arena.Remove("Adam");
        Console.WriteLine(arena.Count);
        arena.Add(g3); 
        Console.WriteLine(arena.GetGladitorWithHighestStatPower());
        Console.WriteLine(arena.GetGladitorWithHighestWeaponPower());
        Console.WriteLine(arena.GetGladitorWithHighestTotalPower());
    }
}

