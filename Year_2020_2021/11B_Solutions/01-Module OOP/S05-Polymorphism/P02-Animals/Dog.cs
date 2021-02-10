namespace P02_Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMySelf()
        {
            return base.ExplainMySelf() + " DJAFF";
        }
    }
}
