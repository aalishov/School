using System;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder sb= new StringBuilder("first line read line");
        sb.Insert(6, "asdasd ");
        sb[0] = 'F';
        Console.WriteLine(sb.ToString());


        //Stopwatch sw = new Stopwatch();
        //sw.Start();
        //string text = "";
        //for (int i = 0; i < 100000; i++)
        //{
        //    text += i;
        //}
        //sw.Stop();

        //Console.WriteLine(text);
        //Console.WriteLine(sw.ElapsedMilliseconds);


        //StringBuilder sb = new StringBuilder();
        //Stopwatch sw1 = new Stopwatch();
        //sw1.Start();
        //for (int i = 0; i < 200000; i++)
        //{
        //    sb.Append(i);
        //}
        //sw1.Stop();

        //Console.WriteLine(sb.ToString());
        //Console.WriteLine(sw1.ElapsedMilliseconds);
    }
}

