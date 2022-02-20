using System;

class Program
{
    static void Main()
    {
        //bool isTrue = (2 > -2) && (5 != 3);  //true
        //bool isTrue = ("1" == "one") && (5 - 2 != 3);//false
        //bool isTrue = 2 * 3 == 6 && 2 * 5 > 10;//false
        bool isTrue = 2 * 3 != 6 && 2 * 5 >= 10 && 2 > -2 && 2 * 5 == 2 + 8 && 9 / 2 == 2; //false
        Console.WriteLine(isTrue);
    }
}

