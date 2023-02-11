using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        decimal bonus = 0;
        if (number <= 100)
        {
            bonus = number + 5;
            if (number%2==0)
            {
                bonus += 1;
            }
            if (number%10==5)
            {
                bonus += 2;
            }
        }
        if (number > 100)
        {
            bonus =(decimal) (number + number * 0.20);
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            if (number % 10 == 5)
            {
                bonus += 2;
            }
        }
        if (number > 1000)
        {
            bonus = (decimal)(number + 0.10 * number);
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            if (number % 10 == 5)
            {
                bonus += 2;
            }
        }
        Console.WriteLine(bonus - number);
        Console.WriteLine(bonus);
        
    }
}

