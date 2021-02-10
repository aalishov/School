using System;

namespace P05_Oscari
{
    class Program
    {
        static void Main(string[] args)
        {
            int naem = int.Parse(Console.ReadLine());

            double statuetki = naem - naem * 0.3;

            double ketyring = statuetki -statuetki * 0.15;

            double ozvuchavane = 0.5 * ketyring;

            double total = naem + statuetki + ketyring + ozvuchavane;
            Console.WriteLine(statuetki);
            Console.WriteLine(ketyring);
            Console.WriteLine(ozvuchavane);
            Console.WriteLine(total);
        }
    }
}
