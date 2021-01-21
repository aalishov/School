using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            default:
                Console.WriteLine("Error...");
                break;
        }
    }

}

