
namespace P10_BordereControl
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<ICitizen> citizens = new List<ICitizen>();
        public static void Main()
        {
            while (true)
            {
                Console.Write("Enter info:");
                string[] info = Console.ReadLine().Split(' ');

                if (info[0] == "End") { break; }

                if (info.Length == 2)
                {
                    citizens.Add(new Robot() { Model = info[0], Id = info[1] });
                }
                else if (info.Length == 3)
                {
                    citizens.Add(new Person() { Name = info[0], Age = int.Parse(info[1]), Id = info[2] });
                }
            }
            Console.Write("Enter invalid id info: ");
            string falseId = Console.ReadLine();

            foreach (var c in citizens)
            {
                int startIndex = c.Id.Length - falseId.Length;
                string idEnd = c.Id.Substring(startIndex);
                if (falseId==idEnd)
                {
                    Console.WriteLine($"False citizens => {c.Id}");
                }
            }
        }
    }
}
