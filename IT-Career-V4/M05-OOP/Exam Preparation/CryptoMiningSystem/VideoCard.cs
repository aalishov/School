namespace CryptoMiningSystem
{
    using System;
    public abstract class VideoCard : Component, IVideoCard
    {
        private int ram;
        public VideoCard(string model, decimal price, int generation) : base(model, price, generation)
        {
        }
        public int Ram
        {
            get { return ram; }
            private set
            {
                if (value < 0 || value > 32)
                {
                    throw new ArgumentException($"{this.GetType().Name} ram cannot less or equal to 0 and more than 32!");
                }
                ram = value;
            }
        }
        public virtual int MinedMoneyPerHour
        {
            get
            {
                return this.Ram * this.Generation / 10;
            }
        }
        public override int LifeWorkingHours
        {
            get
            {
                return this.Ram * this.Generation * 10;
            }
        }
    }
}
