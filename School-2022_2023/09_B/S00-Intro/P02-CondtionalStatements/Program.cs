using System;

public class Program
{
    static void Main()
    {
        string cmd=Console.ReadLine();

        //if (cmd=="Play")
        //{
        //    Console.WriteLine("Play");
        //}
        //else if (cmd=="Stop")
        //{
        //    Console.WriteLine("Stop");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid command!");
        //}

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
}

