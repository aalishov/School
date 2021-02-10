namespace P02_Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMySelf()
        {
            return base.ExplainMySelf()+ $" I'm {nameof(Cat)}";
        }
    }
}
