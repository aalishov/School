using System;

class Program
{
    static void Main(string[] args)
    {
        string cmd = Console.ReadLine();

        switch (cmd)
        {
            case "red":
            case "blue":
                Console.WriteLine($"{cmd} is color");
                break;
            case "1":
            case "2":
            case "3":
            case "4":
            case "10":
                Console.WriteLine($"{cmd} is number");
                for (int i = 0; i <int.Parse(cmd); i++)
                {
                    Console.WriteLine(new string('*', int.Parse(cmd))); 
                }
                break;
            default:
                break;
        }
    }
}

