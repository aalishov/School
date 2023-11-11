namespace P01_ConvertToMagicNumber

{
    using System;
    public class Program
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double mag = num * 1.5 + 40;
            Console.WriteLine(mag);
        }
    }
}