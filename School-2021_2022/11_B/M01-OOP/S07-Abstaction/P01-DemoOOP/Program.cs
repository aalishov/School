
namespace P01_DemoOOP
{
    public class Program
    {
        public static void Main()
        {

            Animal animal = new Animal("BigDog", -5);

            Dog dog = new Dog("Big Dog","Pincher");

            Cat cat = new Cat("Tom", 2);

            Console.WriteLine(animal);
            Console.WriteLine(dog);
            Console.WriteLine(cat);
        }
    }
}