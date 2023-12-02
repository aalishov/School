namespace P01_DogInheritsAnimal
{
    internal class Program
    {
        static void Main()
        {
            Puppy dog = new Puppy();
            dog.Eat();
            dog.Bark();
            dog.Weep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}