namespace P02_AnimalsInheritance
{
    using System;
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine($"{this.Name} => Weeping...");
        }
    }
}
