public class Program
{
    public static void Main()
    {
        string cmd = Console.ReadLine();

        switch (cmd)
        {
            case "print":
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                break;
            case "even":
                for (int i = 0; i < 10; i+=2)
                {
                    Console.WriteLine(i);
                }
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }
}

