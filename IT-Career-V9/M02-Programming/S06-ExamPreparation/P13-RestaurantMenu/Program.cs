public class Program
{
    private static List<string> menu = new List<string>();
    public static void Main()
    {
        menu.AddRange((Console.ReadLine() ?? "").Split(", "));

        while (true)
        {
            string cmd = Console.ReadLine() ?? "";
            switch (cmd)
            {
                case "Add dish":
                    string dishToAdd = Console.ReadLine() ?? "";
                    menu.Add(dishToAdd);
                    break;
                case "Add dish on position":
                    string dishToAddOnPosition = Console.ReadLine() ?? "";
                    int position = int.Parse(Console.ReadLine() ?? "0");
                    menu.Insert(position, dishToAddOnPosition);
                    break;
                case "Remove dish on position":
                    int positionToRemove = int.Parse(Console.ReadLine() ?? "0");
                    menu.RemoveAt(positionToRemove);
                    break;
                case "Remove last dish":
                    menu.RemoveAt(menu.Count - 1);
                    break;
                case "Remove first dish":
                    menu.RemoveAt(0);
                    break;
                case "Sort menu":
                    menu.Sort();
                    break;
                case "Reverse menu":
                    menu.Reverse();
                    break;
                case "END OF MENU":
                    Console.WriteLine(string.Join(", ", menu));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}