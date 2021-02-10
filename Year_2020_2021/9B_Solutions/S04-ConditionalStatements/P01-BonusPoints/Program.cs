using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        double bonusPoints = 0;

        if (num <= 100)
        {
            bonusPoints += 5; //bonusPoints = bonusPoints+5;
        }
        else if (num > 1000)
        {
            bonusPoints += num * 10 / 100.0;
        }
        else
        {
            bonusPoints += num * 20 / 100.0;
        }

        if (num % 2 == 0)
        {
            bonusPoints++;
        }
        else if (num % 10 == 5)
        {
            bonusPoints += 2;
        }

        double result = num + bonusPoints;

        Console.WriteLine(bonusPoints);
        Console.WriteLine(result);
    }
}

