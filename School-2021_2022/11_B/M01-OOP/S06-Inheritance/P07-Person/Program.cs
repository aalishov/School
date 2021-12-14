using System;

namespace P07_Person
{
    class Program
    {
        static void Main()
        {
            Person father = new Person("John",33);
            Person mother = new Person("Jane", 28);
            Child child = new Child("Niki", 3, mother, father);
            Console.WriteLine(father);
            Console.WriteLine(mother);
            Console.WriteLine(child);
        }
    }
}
