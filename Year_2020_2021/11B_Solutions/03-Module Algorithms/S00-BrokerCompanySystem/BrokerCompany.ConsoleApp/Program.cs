using System;
using System.Linq;

namespace BrokerCompany.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            string name = "Green Park Hotel";
            bool isHotel = name.Substring(name.Length - 5, 5) == "Hotel";
            bool isHotel2 = name.Split(' ').Last() == "Hotel";
            Console.WriteLine(isHotel);
            Console.WriteLine(isHotel2);
        }
    }
}
