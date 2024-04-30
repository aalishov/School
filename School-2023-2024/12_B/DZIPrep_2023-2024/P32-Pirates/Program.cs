using System.Text;

public class Program
{
    private static Dictionary<string, int> townPopullation = new Dictionary<string, int>();
    private static Dictionary<string, double> townGold = new Dictionary<string, double>();
    static void Main()
    {
        CreateTowns();
        Action();

    }

    private static void Action()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split("=>");
            string cmd = input[0];
            switch (cmd)
            {
                case "Plunder":
                    string town = input[1];
                    int popullation = int.Parse(input[2]);
                    double gold = double.Parse(input[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {popullation} citizens killed.");
                    if (townPopullation.ContainsKey(town))
                    {
                        townPopullation[town] -= popullation;
                        townGold[town] -= gold;
                        if (townPopullation[town] == 0 || townGold[town] == 0)
                        {
                            townPopullation.Remove(town);
                            townGold.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                    }
                    break;
                case "Prosper":
                    town = input[1];
                    gold = double.Parse(input[2]);
                    if (townPopullation.ContainsKey(town))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine($"Gold added cannot be a negative number!");
                            continue;
                        }
                        townGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townGold[town]} gold.");
                    }
                    break;
                case "End":
                    StringBuilder sb = new StringBuilder();
                    if (townPopullation.Any())
                    {
                        sb.AppendLine($"Ahoy, Captain! There are {townPopullation.Count} wealthy settlements to go to:");
                        foreach (var item in townPopullation)
                        {
                            string townName = item.Key;
                            sb.AppendLine($"{townName} -> Population: {item.Value} citizens, Gold: {townGold[townName]} kg");
                        }
                    }
                    else
                    {
                        sb.AppendLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                    }
                    Console.WriteLine(sb.ToString().TrimEnd());
                    Environment.Exit(0);
                    break;
            }

        }
    }

    private static void CreateTowns()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split("||");
            string town = input[0];
            if (town == "Sail")
            {
                break;
            }
            if (townPopullation.ContainsKey(town))
            {
                townPopullation[town] += int.Parse(input[1]);
                townGold[town] += double.Parse(input[2]);
            }
            else
            {
                townPopullation.Add(town, int.Parse(input[1]));
                townGold.Add(town, double.Parse(input[2]));
            }
        }
    }
}
