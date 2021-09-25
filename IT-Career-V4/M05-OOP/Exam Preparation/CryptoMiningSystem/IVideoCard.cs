namespace CryptoMiningSystem
{
   public interface IVideoCard : IComponent
    {
        public int Ram { get;  }
        public int MinedMoneyPerHour { get;  }
    }
}
