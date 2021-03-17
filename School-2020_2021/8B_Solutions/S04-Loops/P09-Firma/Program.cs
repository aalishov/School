using System;


class Program
{   //Задача 1 на страница 99
    static void Main()
    {
        int year = 2010;
        double products = 130;
        int count = 0;

        while (products>=10)
        {
            year++;
            products *= 0.9; //products=products*0.9;
            Console.WriteLine($"Year: {year} => products: {products} tones");
            count++;
        }

        Console.WriteLine($"Year: {year}");
    }
}

