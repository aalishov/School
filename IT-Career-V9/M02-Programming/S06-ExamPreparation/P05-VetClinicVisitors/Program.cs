public class Program
{
    public static void Main()
    {
        List<string> owners = Console.ReadLine()!
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (true)
        {
            string cmd = Console.ReadLine()!;
            if (cmd == "END OF OWNERS") { break; }

            switch (cmd)
            {
                case "Add owner":
                    string ownerName = Console.ReadLine()!;
                    owners.Add(ownerName);
                    break;
                case "Add owner on position":
                    ownerName = Console.ReadLine()!;
                    int position = int.Parse(Console.ReadLine()!);
                    owners.Insert(position, ownerName);
                    break;
                case "Remove owner on position":
                    position = int.Parse(Console.ReadLine()!);
                    owners.RemoveAt(position);
                    break;
                case "Remove last owner":
                    owners.RemoveAt(owners.Count - 1);
                    break;
                case "Remove first owner":
                    owners.RemoveAt(0);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", owners));
    }
}