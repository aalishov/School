using System;
using System.Reflection;

namespace P05_ValidateAge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int age = EnterAgeBetween(10);
            Console.WriteLine("Good bye!");
        }

        static int EnterAge()
        {
            while (true)
            {
                Console.Write("Enter age: ");
                string ageString = Console.ReadLine();
                try
                {
                    int age = int.Parse(ageString);
                    if (age<0||age>99)
                    {
                        Console.WriteLine("Invalid age! Enter value between [0..99]!");
                    }
                    else
                    {
                        return age;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }
        }
        static int EnterAgeBetween(int minAge,int maxAge=int.MaxValue)
        {
            while (true)
            {
                if (maxAge==int.MaxValue)
                {
                    Console.Write($"Enter age greather than {minAge}: ");
                }
                else
                {
                    Console.Write($"Enter age between [{minAge}..{maxAge}]: ");
                }               
                string ageString = Console.ReadLine();
                try
                {
                    int age = int.Parse(ageString);
                    if (age < minAge || age > maxAge)
                    {
                        Console.WriteLine($"Invalid age! Enter value between [{minAge}..{maxAge}]!");
                    }
                    else
                    {
                        return age;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }
        }
    }
}
