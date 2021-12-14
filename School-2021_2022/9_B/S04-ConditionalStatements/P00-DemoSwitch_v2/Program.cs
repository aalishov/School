using System;

namespace P00_DemoSwitch_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "apple":
                case "orange":
                    Console.WriteLine("fruits");
                    break;
                case "tomato":
                    Console.WriteLine("vegetables");
                    break;
                default:
                    break;
            }
            //if (cmd== "apple" ||cmd== "orange")
            //{
            //    Console.WriteLine("fruits");
            //}
        }
    }
}
