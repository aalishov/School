using System.Text;

public class Program
{
    private static string fileName = "names.txt";
    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        var names = File.ReadAllLines(fileName).ToList();

        while (names.Count>0)
        {
            Console.WriteLine("[R]andom name, [E]nd");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "R":
                    names.RemoveAt(GetRandomName(names));
                    break;
                case "E":
                    Environment.Exit(0);
                    break;
            }
        }

    }

    private static int GetRandomName(List<string> names)
    {
        int randomNamesCount = new Random().Next(5, 10);

        for (int i = 0; i < randomNamesCount; i++)
        {
            int randomIndex = new Random().Next(0, names.Count);
            Console.ForegroundColor=(ConsoleColor)new Random().Next(1,15);
            Console.WriteLine(names[randomIndex]);
            Thread.Sleep(500);
            Console.Clear();
        }

        Console.WriteLine();
        int nameIndex = new Random().Next(0, names.Count);

        Console.WriteLine(names[nameIndex]);
        return nameIndex;
    }
}

