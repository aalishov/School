using System.Text;

public class Program
{
    static void Main()
    {
        Dictionary<string, int> populationTowns = new Dictionary<string, int>();
        Dictionary<string, double> goldTowns = new Dictionary<string, double>();
        int count = 0;
        while (true)
        {
            string[] input = Console.ReadLine().Split("||");
            if (input[0] == "Sail")
            {
                break;
            }
            string name = input[0];
            int population = int.Parse(input[1]);
            double gold = double.Parse(input[2]);
            if (!populationTowns.ContainsKey(name))
            {
                populationTowns.Add(name, population);
                goldTowns.Add(name, gold);
                count++;
            }
            else
            {
                populationTowns[name] += population;
                goldTowns[name] += gold;
            }
        }
        while (true)
        {
            string[] cmd = Console.ReadLine().Split("=>");
            if (cmd[0] == "End")
            {
                break;
            }

            if (cmd[0] == "Plunder")
            {
                string town = cmd[1];
                int people = int.Parse(cmd[2]);
                double gold = double.Parse(cmd[3]);
                populationTowns[town] -= people;
                goldTowns[town] -= gold;
                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                if (populationTowns[town] <= 0 || goldTowns[town] <= 0)
                {
                    populationTowns.Remove(town);
                    goldTowns.Remove(town);
                    count--;
                    Console.WriteLine($"{town} has been wiped off the map!");
                }
            }
            if (cmd[0] == "Prosper")
            {
                string town = cmd[1];
                double gold = double.Parse(cmd[2]);
                if (gold < 0)
                {
                    Console.WriteLine("Gold added cannot be a negative number!");

                }
                else
                {
                    goldTowns[town] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {goldTowns[town]} gold.");
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        if (count > 0)
        {
            sb.AppendLine($"Ahoy, Captain! There are {count} wealthy settlements to go to:");
            foreach (var item in populationTowns)
            {
                sb.AppendLine($"{item.Key} -> Population: {populationTowns[item.Key]} citizens, Gold: {goldTowns[item.Key]} kg");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        else { Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!"); }
    }
}
