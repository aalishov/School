namespace CryptoMiningSystem
{
    public class HighPerformanceProcessor : Processor
    {
        public HighPerformanceProcessor(string model, decimal price, int generation) : base(model, price, generation, 8)
        {
        }
    }
}
