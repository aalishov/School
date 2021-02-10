using System;

class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string male = Console.ReadLine();

        switch (male)
        {
            case "m":
            case "male":
                if (age<16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
                break;
            case "f":
            case "female":
                if (age<16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
                break;
            default:
                break;
        }
    }
}

