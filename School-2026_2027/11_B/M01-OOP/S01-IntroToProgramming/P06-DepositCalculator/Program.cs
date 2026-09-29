using System;
public class Program
{
    static void Main()
    {
        double depositAmount = double.Parse(Console.ReadLine());
        int depositPeriod = int.Parse(Console.ReadLine());
        double annualInterestRate = double.Parse(Console.ReadLine());
        double sum = depositAmount + depositPeriod * ((depositAmount * annualInterestRate/100) / 12.00);
        Console.WriteLine(sum);
    }
}

