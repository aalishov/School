using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        sb.Append(input);

        // Remove  8 3
        while (true)
        {
            string[] cmdInfo = Console.ReadLine().Split(' ');

            string cmd = cmdInfo[0];

            if (cmd == "Append")
            {
                string add = cmdInfo[1];
                sb.Append(add);
            }
            else if (cmd == "Remove")
            {
                int pos = int.Parse(cmdInfo[1]);
                int number = int.Parse(cmdInfo[2]);
                sb.Remove(pos, number);
            }
            else if (cmd == "Insert")
            {
                int pos = int.Parse(cmdInfo[1]);
                string add = cmdInfo[2];
                sb.Insert(pos, add);
            }
            else if (cmd == "Replace")
            {
                string oldString = cmdInfo[1];
                string newString = cmdInfo[2];
                sb.Replace(oldString, newString);
            }
            else if(cmd=="End")
            {
                Environment.Exit(0);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

