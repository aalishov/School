public class Program
{
    public static void Main()
    {
        List<string> inventory = Console.ReadLine().Split(", ").ToList();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" - ").ToArray();
            string cmd = input[0];
            
            switch (cmd)
            {
                case "Collect":
                    string item = input[1];
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                    break;
                case "Drop":
                    item = input[1];
                    inventory.Remove(item);
                    break;
                case "Combine Items":
                    string[] items = input[1].Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];
                    if (inventory.Contains(oldItem))
                    {
                        int index = inventory.IndexOf(oldItem);
                        inventory.Insert(index + 1, newItem);
                    }
                    break;
                case "Renew":
                    item= input[1];
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                    break;
                case "Craft!":
                    Console.WriteLine(string.Join(", ",inventory));
                    Environment.Exit(0);
                    break;

            }

        }
    }
}
