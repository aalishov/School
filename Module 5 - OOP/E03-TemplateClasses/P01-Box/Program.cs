namespace P01_Box
{
    using System;
    public class Program
    {
        public static void Main()
        {
            Box<int> redBox = new Box<int>("Red");
            Box<string> blueBox = new Box<string>("Blue");
            Box<Cat> catBox = new Box<Cat>("White");

            redBox.Add(5);
            redBox.Add(12);
            blueBox.Add("Apple");
            blueBox.Add("Banana");
            blueBox.Add("asdasd");
            catBox.Add(new Cat("Pisana", 12, "Persiiska"));
            catBox.Add(new Cat("Lucki", 5, "Persiiska"));

            Console.WriteLine(redBox.PrintBoxElements());
            Console.WriteLine(blueBox.PrintBoxElements());
            Console.WriteLine(catBox.PrintBoxElements());
        }
    }
}
