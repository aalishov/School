using System;

class Program
{
    //Извличане на част от низ
    static void Main()
    {
        string s = "Велинград";
        string s1 = s.Substring(5,4);

        string s3 = "Информационни технологии";
        string s4 = s3.Substring(14,10);

        Console.WriteLine(s1); //град
        Console.WriteLine(s4); //технологии
    }
}

