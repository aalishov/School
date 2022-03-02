using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Hi!");
        //sb[0] = 'h';//hi!
        //sb.Remove(0, 1); //"i!"
        //sb.Insert(0, "@"); //"@Hi!"
        sb.Replace('!', '*');// "Hi*";
        Console.WriteLine(sb);
    }
}
