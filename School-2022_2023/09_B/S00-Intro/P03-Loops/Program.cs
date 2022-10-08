using System;

public class Program
{
    static void Main()
    {
        //for (int i = 1; i <= 1000; i++)
        //{
        //    Console.WriteLine("Print:");
        //    Console.WriteLine($"\t{i}");
        //}

        string cmd = string.Empty;
        while ((cmd=Console.ReadLine())!="End")
        {
            switch (cmd)
            {
                case "Play":
                    Console.WriteLine("Play");
                    break;
                case "Stop":
                    Console.WriteLine("Stop");
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

        //do
        //{

        //} while (true);
    }
}

