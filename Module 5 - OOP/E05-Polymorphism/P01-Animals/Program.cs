using System;

namespace P01_Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Cat("Pesho", "Whiskas");
            Animal animal2 = new Dog("Gosho", "Meat");

            Trainer trainer = new Trainer(animal1);
            trainer.Make();
            trainer.Animal = animal2;
            trainer.Make();

        }
    }
}
