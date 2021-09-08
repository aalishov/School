using System;

class Program
{
    static void Main()
    {
        //string name = Console.ReadLine();
        //string emptyStr = string.Empty;
        //string emptyStr2 = "";
        //string whiteSpace = "     ";
        //int num = 150;
        //int num2 = int.Parse(Console.ReadLine());
        //int num3 = int.Parse(Console.ReadLine());
        //Console.WriteLine($"{num2} / {num3} = {num2 / num3} -> остатък {num2 % num3}");
        //decimal num4 = 15.565465465465465456465456456456456456454564564564m;
        //double num5 = 15.565465465465465456465456456456456456454564564564;
        //Console.WriteLine(num4);
        //Console.WriteLine(num5);

        bool isTrue = true;
        bool isFalse = false;
        bool isTrue1 = 5 != (2 + 3); //false
        bool isTrue2 = (15 + 2) == (2 + 15);//true

        string evenNum = string.Empty;
        string oddNum = string.Empty;

        for (int i = 0; i < 15; i += 2)
        {
            if (i % 2 == 0)
            {
                evenNum += $"{i} ";
            }
            else
            {
                oddNum += $"{i} ";
            }
        }
        //Console.WriteLine(evenNum);
        //Console.WriteLine(oddNum);
    }
}

