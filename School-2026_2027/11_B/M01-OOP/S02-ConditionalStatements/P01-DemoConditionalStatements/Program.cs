using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        bool isTrue = true;
        //int number = int.Parse(Console.ReadLine());

        // && AND
        // || OR

        string switch_on = Console.ReadLine();

        switch (switch_on)
        {
            case "1":
            case "one":
                Console.WriteLine("Case 1");
                break;
            case "2":
            case "two":
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

        if (switch_on=="1"||switch_on=="one")
        {
            Console.WriteLine("Case 1");
        }

        
    }
}

