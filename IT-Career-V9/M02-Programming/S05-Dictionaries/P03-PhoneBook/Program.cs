public class Program
{
    public static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            string[] line = Console.ReadLine().Split(" ");
            string cmd = line[0];

            switch (cmd)
            {
                case "A":
                    string name = line[1];
                    string number = line[2];
                    phoneBook[name] = number;
                    break;
                case "S":
                    string searchName = line[1];
                    if (phoneBook.ContainsKey(searchName))
                    {
                        Console.WriteLine($"{searchName} -> {phoneBook[searchName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searchName} does not exist.");
                    }
                    break;
                case "END":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}

