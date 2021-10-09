namespace CryptoMiningSystem
{
    public interface IUser
    {
        public string Name { get; }
        public int Stars { get; }
        public decimal Money { get; set; }
        public decimal Profits { get; set; }
        public IComputer Computer { get; set; }
    }
}
