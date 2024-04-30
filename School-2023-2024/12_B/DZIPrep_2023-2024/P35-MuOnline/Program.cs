
using System.Threading;

public class Program
{
    public static void Main()
    {
        int health = 100;
        int bitcoins = 0;
        int bestRoom;

        string[] input = Console.ReadLine().Split("|").ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            string[] room = input[i].Split(" ");
            switch(room[0])
            {
                case "potion":
                    int healing = int.Parse(room[1]);
                    int healingAmount = 0;

                    if (health + healing <= 100)
                    {
                        healingAmount = healing;
                        health += healing;
                    }
                    else
                    {
                        healingAmount = 100 - health;
                        health = 100;
                    }
                    Console.WriteLine($"You healed for {healingAmount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                    break;
                case "chest":
                    int amount = int.Parse(room[1]);
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                    break;
                default:
                    int damage = int.Parse(room[1]);
                    string monster = room[0];
                    bestRoom = i + 1;
                    if (health - damage > 0)
                    {
                        health -= damage;
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        Environment.Exit(0);
                    }
                    break;
            }
        }
        Console.WriteLine("You've made it!");
        Console.WriteLine($"Bitcoins: {bitcoins}");
        Console.WriteLine($"Health: {health}");
    }
}

