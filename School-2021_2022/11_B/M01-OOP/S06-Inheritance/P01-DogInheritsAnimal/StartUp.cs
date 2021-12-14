using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Bark());
        }
    }
}
