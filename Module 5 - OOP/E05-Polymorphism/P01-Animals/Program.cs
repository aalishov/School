using System;

namespace P01_Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Object animal1 = new Cat("Pesho", "Whiskas");
            Animal animal2 = new Dog("Gosho", "Meat");

            Cat cat = (Cat)animal1;

            Console.WriteLine(cat.ExplainMyself()+cat.Name);
            Console.WriteLine(animal2.ExplainMyself());
        }
    }
}
