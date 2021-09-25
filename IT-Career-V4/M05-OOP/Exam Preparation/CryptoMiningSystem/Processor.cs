namespace CryptoMiningSystem
{
    using System;
    public abstract class Processor : Component, IProcessor
    {
        public Processor(string model, decimal price, int generation, int mineMultiplier) : base(model, price, generation)
        {
            this.MineMultiplier = mineMultiplier;
        }
        public int MineMultiplier { get; private set; }
        public override int Generation
        {
            get { return base.Generation; }
            protected set
            {
                if (value>9)
                {
                    throw new ArgumentException($"{this.GetType().Name} generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }

        public override int LifeWorkingHours
        {
            get { return this.Generation * 100; }
        }
        
    }
}
