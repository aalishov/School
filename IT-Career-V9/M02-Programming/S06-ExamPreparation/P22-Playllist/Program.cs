public class Program
{
    private static List<string> list = new List<string>();
    public static void Main()
    {
        list.AddRange((Console.ReadLine() ?? string.Empty).Split(", ", StringSplitOptions.RemoveEmptyEntries));

        while (true)
        {
            string cmd = Console.ReadLine() ?? string.Empty;
            switch (cmd)
            {
                case "Add song":
                    string song = Console.ReadLine() ?? string.Empty;
                    list.Add(song);
                    break;
                case "Add song on position":
                    string songToAdd = Console.ReadLine() ?? string.Empty;
                    int position = int.Parse(Console.ReadLine() ?? string.Empty);
                    list.Insert(position, songToAdd);
                    break;
                case "Remove song on position":
                    int positionToRemove = int.Parse(Console.ReadLine() ?? string.Empty);
                    list.RemoveAt(positionToRemove);
                    break;
                case "Remove last song":
                    list.RemoveAt(list.Count - 1);
                    break;
                case "Remove first song":
                    list.RemoveAt(0);
                    break;
                case "Sort playlist":
                    list.Sort();
                    break;
                case "Reverse playlist":
                    list.Reverse();
                    break;
                case "END OF PLAYLIST":
                    Console.WriteLine(string.Join(", ", list));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}