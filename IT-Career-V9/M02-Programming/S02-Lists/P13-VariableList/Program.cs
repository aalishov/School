public class Program
{
    private static List<int> nums = null;

    public static void Main()
    {
        nums = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();

        while (true)
        {
            string[] input = Console.ReadLine()!.Split(" ").ToArray();
            string cmd = input[0];

            switch (cmd)
            {
                case "Delete":
                    Delete(input.Skip(1).Take(1).ToArray());
                    break;
                case "Insert":
                    Insert(input.Skip(1).Take(2).ToArray());
                    break;
                case "Even":
                    Even();
                    break;
                case "Odd":
                    Odd();
                    break;
            }
        }
    }

    private static void Odd()
    {
        Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0)));
        Environment.Exit(0);
    }

    private static void Even()
    {
        Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0)));
        Environment.Exit(0);
    }

    private static void Insert(string[] args)
    {
        int item = int.Parse(args[0]);
        int index = int.Parse(args[1]);
        nums.Insert(index, item);
    }

    private static void Delete(string[] args)
    {
        int item = int.Parse(args[0]);
        nums.RemoveAll(x => x == item);
    }
}

