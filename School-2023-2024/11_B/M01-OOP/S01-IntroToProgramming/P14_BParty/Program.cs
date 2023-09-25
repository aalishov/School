namespace P14_BParty
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            double naemZala = Double.Parse(Console.ReadLine());
            double tortaCena = 0.20 * naemZala;
            double napitkiCena = tortaCena * 0.55;
            double cenaAnimator = 1/3.0 * naemZala;
            double neededMoney = naemZala + tortaCena + napitkiCena + cenaAnimator;
            Console.WriteLine($"{neededMoney}");

        }
    }
}