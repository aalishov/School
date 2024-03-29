
public class Program
{
  public  static void Main()
    {
        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        keyMaterials.Add("shards", 0);
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("motes", 0);

        SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
        

        while (true)
        {
            string[] input = Console.ReadLine().ToLower().Split(" ");

            for (int i = 0; i < input.Length; i += 2)
            {
                int quantity = int.Parse(input[i]);
                string material = input[i + 1];

                if (keyMaterials.ContainsKey(material))
                {
                    keyMaterials[material] += quantity;
                }
                else
                {
                    if (junkMaterials.ContainsKey(material))
                    {
                        junkMaterials[material] += quantity;
                    }
                    else
                    {
                        junkMaterials.Add(material, quantity);
                    }

                }
                if (keyMaterials["shards"] >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    keyMaterials["shards"] -= 250;

                    PrintMaterials(keyMaterials, junkMaterials);
                    Environment.Exit(0);
                }
                else if (keyMaterials["fragments"] >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    keyMaterials["fragments"] -= 250;
                    PrintMaterials(keyMaterials, junkMaterials);
                    Environment.Exit(0);
                }
                else if (keyMaterials["motes"] >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    keyMaterials["motes"] -= 250;
                    PrintMaterials(keyMaterials, junkMaterials);
                    Environment.Exit(0);
                }
            }

        }

    }
    private static void PrintMaterials(Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junkMaterials)
    {
        foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
        }
        foreach (var item in junkMaterials)
        {
            Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
        }
    }
}

