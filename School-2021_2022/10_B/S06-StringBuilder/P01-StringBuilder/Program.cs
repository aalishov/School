using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Console.ReadLine());

        string[] line = Console.ReadLine()
            .Split(' ');
        string cmd = line[0];

        if (cmd=="Append")
        {
            //Append word
            sb.Append(line[1]);
        }
        else if (cmd=="Remove")
        {
            int pos = int.Parse(line[1]);
            int number = int.Parse(line[2]);
            sb.Remove(pos, number);
        }
        else if (cmd=="Insert")
        {
            int pos = int.Parse(line[1]);
            string word = line[2];
            sb.Insert(pos, word);
        }
        else if(cmd=="Replace")
        {
            string oldString = line[1];
            string newString = line[2];
            sb.Replace(oldString, newString);
        }
        Console.WriteLine(sb);
    }
}

