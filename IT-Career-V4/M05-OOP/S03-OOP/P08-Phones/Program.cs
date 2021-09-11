namespace P08_Phones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            SmartPhone phone = new SmartPhone();
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            foreach (var number in numbers)
            {
                Console.WriteLine(phone.Call(number));
            }
            List<string> urls= Console.ReadLine().Split(' ').ToList();
            foreach (var url in urls)
            {
                Console.WriteLine(phone.Browse(url));
            }
        }
    }
}
