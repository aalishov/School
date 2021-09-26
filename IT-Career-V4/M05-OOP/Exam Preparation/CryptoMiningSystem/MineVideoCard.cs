namespace CryptoMiningSystem
{
    using System;
    public class MineVideoCard : VideoCard
    {
        public MineVideoCard(string model, decimal price, int generation, int ram) : base(model, price, generation, ram)
        {
            this.LifeWorkingHours *= 2;
        }
        public override int Generation
        {
            get { return base.Generation; }
            protected set
            {
                if (value > 6)
                {
                    throw new ArgumentException($"Mine video card generation cannot be more than 6!");
                }
                base.Generation = value;
            }
        }
        public override int MinedMoneyPerHour
        {
            get
            {
                //TODO: Да се провери
                return base.MinedMoneyPerHour * 8;
            }
        }

    }
}
