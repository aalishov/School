using System;

public class Program
{
    public static void Main()
    {
        Dice d6 = new Dice() { Type = "Six side", Side = 6 };
        Dice d9 = new Dice() { Type = "Nine side", Side = 9 };

        for (int i = 0; i < 3; i++)
        {
            d6.Roll();
        }
        for (int i = 0; i < 5; i++)
        {
            d9.Roll();
        }
    }
}