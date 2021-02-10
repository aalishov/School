using System;
using System.Text;

namespace Ex03_P9_SimpleTextEditor
{
    public class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            string undo = "";
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string cmd = input[0];
                

                switch (cmd)
                {
                    case "1":
                        undo = sb.ToString();
                        sb.Append(input[1]);                        
                        break;
                    case "2":
                        undo = sb.ToString();
                        int count = int.Parse(input[1]);
                        if (count>=sb.Length)
                        {
                            sb.Clear();
                        }
                        else
                        {
                            sb.Remove(sb.Length - count, count);
                        }
                        
                        break;
                    case "3":
                        Console.WriteLine(sb[int.Parse(input[1])]);
                        break;
                    case "4":
                        sb.Clear();
                        sb.Append(undo);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(sb.ToString());
            }
            
        }
    }
}
