using System;

class Program
{
    static void Main()
    {
        double points = double.Parse(Console.ReadLine());
        double bonus = 0;

        if (points <= 100)
        {
            bonus += 5;
        }
        else if (points > 100 && points <= 1000)
        {
            bonus += points * 0.2;
        }
        else
        {
            bonus += points * 0.1;
        }

        if (points % 2 == 0)
        {
            bonus++;
        }
        else if (points % 10 == 5)
        {
            bonus += 2;
        }

        points += bonus;

        Console.WriteLine(bonus);
        Console.WriteLine(points);

    }
}

