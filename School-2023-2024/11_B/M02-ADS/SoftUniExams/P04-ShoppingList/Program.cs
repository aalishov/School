public class Program
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split("!").ToList();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];
            switch (cmd)
            {
                case "Urgent":
                    string item = input[1];
                    if (!items.Contains(item))
                    {
                        items.Insert(0, item);
                    }
                    break;
                case "Unnecessary":
                    item = input[1]; 
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                    break;
                case "Correct":
                    string oldItemName = input[1];
                    string newItemName = input[2];
                    if (items.Contains(oldItemName))
                    {
                        int index = items.IndexOf(oldItemName);
                        items.RemoveAt(index);
                        items.Insert(index, newItemName);
                    }
                    break;
                case "Rearrange":
                    item = input[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                    break;
                case "Go":
                    Console.WriteLine(string.Join(", ",items));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}