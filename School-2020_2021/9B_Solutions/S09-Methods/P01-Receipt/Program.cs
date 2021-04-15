using System;

namespace P01_Receipt
{
    public class Program
    {
        static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintHeader()
        {
            // new string('-',10) <=> ----------
            Console.WriteLine("CASH RECEIPT");
            PrintLine();
        }
        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void PrintFooter()
        {
            PrintLine();
            Console.WriteLine("© SoftUni");
        }

        public static void PrintLine()
        {
            Console.WriteLine(new string('-', 30));
        }
    }
}
