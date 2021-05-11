using System;
using System.Collections.Generic;

namespace Companies
{
    class Program
    {
        private static Dictionary<string, Employee> emploies = new Dictionary<string, Employee>();
        static void Main(string[] args)
        {
            Company company = new Company();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                string cmd = input[0];
                if (cmd=="end")
                {
                    break;
                }
                switch (cmd)
                {
                    case "CreateEmployee":
                        if (input.Length==5)
                        {
                            CreateEmployee(input[1], input[2], input[3], int.Parse(input[4]));
                        }
                        else if (input.Length == 6)
                        {
                            CreateEmployee(input[1], input[2], input[3], int.Parse(input[4]),decimal.Parse(input[5]));
                        }
                        break;
                    case "PrintEmployeeInfo":
                        PrintEmployeeInfo(input[1]);
                        break;
                }
            }
        }

        public static void CreateEmployee(string id, string firstName, string lastName,int age)
        {
            if (!emploies.ContainsKey(id))
            {
                emploies.Add(id, new Employee(id, firstName, lastName,age));
            }
            else
            {
                Console.WriteLine("Employee already exist!");
            }
        }
        public static void CreateEmployee(string id, string firstName, string lastName, int age, decimal salary)
        {
            if (!emploies.ContainsKey(id))
            {
                emploies.Add(id, new Employee(id, firstName, lastName, age, salary));
            }
            else
            {
                Console.WriteLine("Employee already exist!");
            }
        }
    
        public static void PrintEmployeeInfo(string id)
        {
            if (emploies.ContainsKey(id))
            {
                Console.WriteLine(emploies[id]);
            }
            else
            {
                Console.WriteLine("Employee not exist!");
            }
        }
    }
}
