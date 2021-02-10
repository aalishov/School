using System;
using System.Collections.Generic;

namespace P05_Smartphone
{
    public class Program
    {
        public static void Main()
        {
            List<string> numbers = new List<string>(Console.ReadLine().Split(' '));
            List<string> saits = new List<string>(Console.ReadLine().Split(' '));

            Smartphone smartphone = new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }
            foreach (var sait in saits)
            {
                Console.WriteLine(smartphone.Browse(sait));
            }
        }
    }
}
