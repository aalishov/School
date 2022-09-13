using System;

namespace Animals
{
    public class StartUp
    {
        static void Main()
        {
            Animal cat = new Cat("Tom", "Whiskas");
            Animal dog = new Dog("Sharo", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
}
