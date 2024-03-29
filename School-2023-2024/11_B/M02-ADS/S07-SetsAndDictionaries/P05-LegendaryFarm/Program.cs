
public class Program
{
    public static void Main()
    {
        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        keyMaterials.Add("shards", 0);
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("motes", 0);

        SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

        bool stop = false;
        string obtainedItem = string.Empty;


        while (!stop)
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
                    obtainedItem = "Shadowmourne";
                    keyMaterials["shards"] -= 250;
                    stop = true;
                    break;
                }
                else if (keyMaterials["fragments"] >= 250)
                {
                    obtainedItem = "Valanyr";
                    keyMaterials["fragments"] -= 250;
                    stop = true;
                    break;
                }
                else if (keyMaterials["motes"] >= 250)
                {
                    obtainedItem = "Dragonwrath";
                    keyMaterials["motes"] -= 250;
                    stop = true;
                    break;
                }
            }

            Console.WriteLine($"{obtainedItem} obtained!");
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

}


