using System;
using System.Collections.Generic;

namespace P06_BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseCitizen> citizens = new List<BaseCitizen>();
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] info = cmd.Split(' ');
                BaseCitizen citizen = null;
                if (info.Length == 3)
                {
                     citizen = new Citizen(info[2], info[0], int.Parse(info[1]));
                }
                else if (info.Length == 2)
                {
                     citizen = new Robot(info[1], info[0]);
                }
                citizens.Add(citizen);
            }
            string invalidNumber = Console.ReadLine();
            foreach (var citizen in citizens)
            {
                if (!citizen.IsValid(invalidNumber))
                {
                    Console.WriteLine($"Invalid -> {citizen.Id}");
                }
            }

        }
    }
}
