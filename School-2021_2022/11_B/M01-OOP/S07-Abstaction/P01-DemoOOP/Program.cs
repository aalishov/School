
namespace P01_DemoOOP
{
    using System;
    public class Program
    {
        public static void Main()
        {
            Animal dog = new Dog("Big Dog", "Pincher");

            Animal cat = new Cat("Tom", 2);

            Dog d = (Dog)dog;
        }
    }
}