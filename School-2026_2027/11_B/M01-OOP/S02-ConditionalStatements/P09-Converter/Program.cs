using System;
public class Program
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string typeConvert = Console.ReadLine();

            if (type == "mm" && typeConvert == "m")
            {
                Console.WriteLine($"{number / 1000:f3}");
            }
            else if (type == "m" && typeConvert == "mm")
            {
                Console.WriteLine($"{number * 1000:f3}");
            }
            else if (type == "cm" && typeConvert == "m")
            {
                Console.WriteLine($"{number / 100:f3}");
            }
            else if (type == "m" && typeConvert == "cm")
            {
                Console.WriteLine($"{number * 100:f3}");
            }
            else if (type == "cm" && typeConvert == "mm")
            {
                Console.WriteLine($"{number * 10:f3}");
            }
            else if (type == "mm" && typeConvert == "cm")
            {
                Console.WriteLine($"{number / 10:f3}");
            }
        }
    }

