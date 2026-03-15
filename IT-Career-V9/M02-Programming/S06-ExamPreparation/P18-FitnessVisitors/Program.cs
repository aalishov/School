public class Program
{
    private static List<string> visitors = new List<string>();
    public static void Main()
    {
        visitors.AddRange(Console.ReadLine()!.Split(", "));

        while (true)
        {
            string cmd = Console.ReadLine()!;

            switch (cmd)
            {
                case "Add visitor":
                    string visitorToAdd = Console.ReadLine()!;
                    visitors.Add(visitorToAdd);
                    break;
                case "Add visitor on position":
                    string visitorToAddOnPosition = Console.ReadLine()!;
                    int positionToAdd = int.Parse(Console.ReadLine()!);
                    visitors.Insert(positionToAdd,visitorToAddOnPosition);
                    break;
                case "Remove visitor on position":
                    int positionToRemove = int.Parse(Console.ReadLine()!);
                    visitors.RemoveAt(positionToRemove);
                    break;
                case "Remove last visitor":
                    visitors.RemoveAt(visitors.Count - 1);
                    break;
                case "Remove first visitor":
                    visitors.RemoveAt(0);
                    break;
                case "END":
                    Console.WriteLine(string.Join(", ",visitors));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

