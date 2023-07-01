using System;

public class Program
{
    public static void Main()
    {
        double price = double.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string extras=Console.ReadLine();
        double finalPrice = 0.0;

        if (type=="Sedan")
        {
            finalPrice = price;
            if (extras=="yes")
            {
                //цена за гуми
                finalPrice += 800;
            }
        }
        else if (type == "Hatchback")
        {
            finalPrice = price * 0.9;
            if (extras=="yes")
            {
                //цена за гуми, фарове и подгрев на предни седалки
                finalPrice += 1800;
            }
        }
        else if (type == "Wagon")
        {
            finalPrice = price * 1.15;
            if (extras == "yes")
            {
                //цена за гуми, навигационна система и подгрев на  седалки
                finalPrice += 2500;
            }
        }

        Console.WriteLine(finalPrice);
    }
}