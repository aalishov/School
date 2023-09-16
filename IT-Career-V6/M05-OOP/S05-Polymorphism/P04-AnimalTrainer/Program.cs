using System.Net.Http.Headers;

namespace P04_AnimalTrainer
{
    public class Program
    {
        public static void Main()
        {
            

            Cat cat1 = new Cat();
            Dog dog1 = new Dog();
            Cat cat2 = new Cat();
            Dog dog2 = new Dog();

            List<IAnimal> animals = new List<IAnimal>() { cat1,dog1, cat2, dog2 };

            Trainer t1 = new Trainer(cat1);

            foreach (var a in animals)
            {
                t1.Animal = a;
                a.Perform();
            }
        }
    }
}