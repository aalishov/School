using System;


public class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());
        double sum = 0;
        int countToy = 0, moneyGift = 10;
        for (int i =1 ; i <=age ; i++) 
        {
            if (i % 2 == 0)
            {
                sum += moneyGift;
                sum--;//Her brother takes 1 lv
                moneyGift += 10;
            }
            else { countToy++; }
        }
        sum += (countToy * toyPrice);
        if (sum>=washingMachinePrice)
        {
            Console.WriteLine($"Yes! {sum-washingMachinePrice:f2} ");
        }
        else
        {
            Console.WriteLine($"No! {washingMachinePrice-sum:f2}");
        }
    }
}

