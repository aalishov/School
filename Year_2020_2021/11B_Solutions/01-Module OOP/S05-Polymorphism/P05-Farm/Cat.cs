namespace P05_Farm
{
    using System;

    public class Cat : Felime
    {
        public string Breed { get; set; }

        public override string Eat(Food food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }
    }
}
