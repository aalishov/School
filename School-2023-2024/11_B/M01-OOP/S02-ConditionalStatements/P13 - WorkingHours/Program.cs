﻿namespace P13___WorkingHours
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                switch(day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    default:
                        Console.WriteLine("closed");
                        break;
                }
            }
            else { Console.WriteLine("closed"); }
        }
    }
}