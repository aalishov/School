using System;

namespace SandBox
{
    public class Program
    {
        public static void Main()
        {
            Robot robot = new Robot("Pesho");
            Robot robot2 = new Robot("Gosho");
            Console.WriteLine(robot2.Name);
        }
    }
}
