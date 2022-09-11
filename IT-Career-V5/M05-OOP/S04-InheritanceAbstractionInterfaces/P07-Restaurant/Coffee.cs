namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double InitialMilliliters = 50;
        private const decimal InitialPrice = 3.5m;
        public Coffee(string name, double caffeine) : base(name, InitialPrice, InitialMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; private set; }
    }
}
