using System;

public class Program
{
    static void Main()
    {
        int startingPoints = int.Parse(Console.ReadLine());
        double totalPoints = 0;

        if (startingPoints<=100)
        {
            totalPoints = startingPoints + 5;
        }
        else if (startingPoints>100&&startingPoints<=1000)
        {
            totalPoints = startingPoints + (startingPoints * 0.2);
        }
        else
        {
            totalPoints = startingPoints + (startingPoints * 0.1);
        }
        if (startingPoints%2==0)
        {
            totalPoints += 1;
        }
        else if (startingPoints%10==5)
        {
            totalPoints += 2;
        }
        Console.WriteLine(totalPoints-startingPoints);
        Console.WriteLine(totalPoints);
    }
}
