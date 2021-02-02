namespace P05_Farm
{
    using System;

    public class Zebra : Mammal
    {
        public override string Eat(Food food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "Zs";
        }
    }
}
