namespace P12_DepositCalculator
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double lihvaYear = double.Parse(Console.ReadLine())/100.0;

            double sum = deposit+ time*((deposit*lihvaYear)/12.0);
            Console.WriteLine(sum);
        }
    }
}