namespace P02_Animals
{
    using System;
    public class Program
    {
        public static void Main()
        {
            Dog dog = new Dog("Spyke", "bones");
            Console.WriteLine(dog.ExplainMySelf());

            Cat cat = new Cat("Tom", "chicken");
            Console.WriteLine(cat.ExplainMySelf());
        }
    }
}
