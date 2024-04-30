using System.Text;

public class Program
{
    static void Main()
    {
        StringBuilder rawKey = new StringBuilder(Console.ReadLine());
        while (true)
        {
            string[] input = Console.ReadLine().Split(">>>").ToArray();
            string cmd = input[0];
            switch (cmd)
            {
                case "Contains":
                    string substring = input[1];
                    if (rawKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    continue;
                    break;
                case "Flip":
                    string type = input[1];
                    int startIndex = int.Parse(input[2]);
                    int endIndex = int.Parse(input[3]);
                    if (type == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            rawKey[i] = char.ToUpper(rawKey[i]);
                        }
                    }
                    else if (type == "Lower")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            rawKey[i] = char.ToLower(rawKey[i]);
                        }
                    }
                    break;
                case "Slice":
                    startIndex = int.Parse(input[1]);
                    endIndex = int.Parse(input[2]);
                    rawKey.Remove(startIndex, endIndex - startIndex);
                    break;
                case "Generate":
                    Console.WriteLine($"Your activation key is: {rawKey}");
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine($"{rawKey}");
        }
    }
}
