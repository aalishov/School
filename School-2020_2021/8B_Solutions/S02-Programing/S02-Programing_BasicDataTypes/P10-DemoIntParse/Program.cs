using System;


class Program
{
    static void Main()
    {
        string sNumber = "12";
        int number = int.Parse(sNumber);
        Console.WriteLine($"{number}+10={(number + 10).ToString()}");

        uint number2= 000;

        //int fNumber = int.Parse("23@"); //Exception
    }
}
