using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        SystemManager manager = new SystemManager();

        while (true)
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            if (input[0]=="Shutdown")
            {
                Console.WriteLine(manager.ShutDown());
            }
            List<string> args = input.Skip(1).ToList();
            switch (input[0])
            {
                case "RegisterMiner":
                    Console.WriteLine(manager.RegisterHarvester(args));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(manager.RegisterProvider(args));
                    break;
                case "Day":
                    string result = manager.Day();
                    if (result!=null) {Console.WriteLine(result); }
                    break;
                case "Check":
                    Console.WriteLine(manager.Check(args));
                    break;
                default:
                    break;
            }
        }
    }
}
