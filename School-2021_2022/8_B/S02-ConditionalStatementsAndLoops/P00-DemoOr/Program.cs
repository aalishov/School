using System;

class Program
{
    static void Main(string[] args)
    {
        //bool isTrue= (2 > -2) || (5 != 3);//true
        //bool isTrue = 6 % 2 == 0 || "left" == "right";//true
        bool isTrue = 2 < -2 || 2 * 2 < 4;//false
        Console.WriteLine(isTrue);
    }
}

