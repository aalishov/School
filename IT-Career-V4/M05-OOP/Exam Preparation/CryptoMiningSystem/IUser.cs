namespace CryptoMiningSystem
{
    public interface IUser
    {
        public string Name { get; }
        public int Stars { get; }
        public decimal Money { get; }
        public IComputer Computer { get; set; }
    }
}
