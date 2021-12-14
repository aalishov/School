using System;

namespace P00_DemoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("NaN");
                    break;
            }

        }
    }
}
