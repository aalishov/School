using System;

public class Program
{
    static void Main()
    {
        int bitcoin = int.Parse (Console.ReadLine());
        double iuan = double.Parse (Console.ReadLine());
        double komisiona = 1-(double.Parse (Console.ReadLine()) / 100.0); 
        double bitcoinLv = bitcoin * 1168;
        double iuanLv = iuan * 0.15* 1.76;
        double total = ((bitcoinLv + iuanLv) / 1.95) * komisiona;
        Console.WriteLine($"{total:f2}");
    }
}

