namespace ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            List<Citizen> citizens = new List<Citizen>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(' ');
                string name = info[0];
                string country = info[1];
                int age = int.Parse(info[2]);

                Citizen citizen = new Citizen(name, age, country);
                citizens.Add(citizen);
            }
            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
