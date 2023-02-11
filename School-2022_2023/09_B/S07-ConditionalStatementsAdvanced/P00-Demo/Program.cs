
public class Program
{
    public static void Main()
    {
        string cmd = Console.ReadLine();

        switch (cmd)
        {
            case "apple":
            case "banana":
                Console.WriteLine("fruit");
                break;
            case "tomato":
                Console.WriteLine("vegetable");
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
        
    }
}
