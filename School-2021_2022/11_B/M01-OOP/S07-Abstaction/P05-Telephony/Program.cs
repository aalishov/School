using System;
using System.Linq;

namespace P05_Telephony
{
    public class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] sites = Console.ReadLine().Split(' ').ToArray();

            foreach (var number in numbers)
            {
                ICalling phone = null;
                if (number.Length == 7)
                {
                    phone = new StationaryPhone();
                }
                else if (number.Length == 10)
                {
                    phone = new Smartphone();
                }
                phone.Call(number);
            }
            foreach (var site in sites)
            {
                Smartphone phone = new Smartphone();
                phone.Browse(site);
            }
        }
    }
}
