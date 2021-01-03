using System;

namespace P10_ExInterfacePhones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] urls = Console.ReadLine().Split(' ');

            Phone phone = new Phone("Nokia");

            foreach (var number in numbers)
            {
                Console.WriteLine(phone.Call(number));
            }

            foreach (var url in urls)
            {
                Console.WriteLine(phone.Browse(url));
            }
        }
    }
}
