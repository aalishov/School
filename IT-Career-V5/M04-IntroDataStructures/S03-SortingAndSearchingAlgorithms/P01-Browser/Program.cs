public class Program
{
    private static Stack<string> back = new Stack<string>();
    private static Stack<string> forward = new Stack<string>();
    private static string currentPage = null;
    public static void Main()
    {
        while (true)
        {
            Console.Write("Enter command: ");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "visit":
                    Console.Write("Enter url: ");
                    string url = Console.ReadLine();
                    Url(url);
                    break;
                case "back":
                    Back();
                    break;
                case "forward":
                    Forward();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
    public static void Url(string url)
    {
        if (currentPage != null)
        {
            back.Push(currentPage);
        }
        currentPage = url;
        Console.WriteLine($"Loading...{currentPage}");
    }
    public static void Back()
    {
        if (back.Any())
        {
            forward.Push(currentPage);
            currentPage = back.Pop();
            Console.WriteLine($"Loading...{currentPage}");
        }
        else
        {
            Console.WriteLine("Empty history...");
        }
    }
    public static void Forward()
    {
        if (forward.Any())
        {
            back.Push(currentPage);
            currentPage = forward.Pop();
            Console.WriteLine($"Loading...{currentPage}");
        }
        else
        {
            Console.WriteLine("Empty previous...");
        }
    }
}