using System;

class Program
{
    static void Main()
    {
        //int num = 15;
        //int num1 = int.Parse(Console.ReadLine());

        //bool isTrue = false;

        //string empty1 = "";
        //string empty2 = string.Empty;
        //string empty3 = "    ";

        //Console.WriteLine($"emty1=>{empty1.Length}");
        //Console.WriteLine($"emty2=>{empty2.Length}");
        //Console.WriteLine($"emty3=>{empty3.Length}");

        //char c = '1';
        //int cNum = 'a';
        //Console.WriteLine($"a->{cNum}");
        //cNum++;
        //Console.WriteLine($"{(char)cNum}->{cNum}");

        //char c = (char)125;
        //Console.WriteLine($"{c}=>{(int)c}");

        //double fNum = 15.20000d;
        //decimal sNum = 12.30000m;

        //decimal sum = (decimal)fNum + sNum;
        //double sum1 = fNum + (double)sNum;

        //Console.WriteLine(sum);
        //Console.WriteLine(sum1);

        //decimal d1 = 1.221232354525344253344233544235434234532434352344235344543m;
        //double d2 = 1.221232354525344253344233544235434234532434352344235344543;
        //Console.WriteLine(d1);
        //Console.WriteLine(d2);
        //Console.WriteLine(d1==(decimal)d2);
        //Console.WriteLine((double)d1==d2);

        string line = Console.ReadLine();

        bool isNum = double.TryParse(line, out _);

        if (isNum)
        {
            Console.WriteLine(int.Parse(line) * 10);
        }
        else
        {
            Console.WriteLine(line.Length * 10);
        }
    }
}

