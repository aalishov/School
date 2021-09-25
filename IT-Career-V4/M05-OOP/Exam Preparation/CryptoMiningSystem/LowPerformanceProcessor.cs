namespace CryptoMiningSystem
{
    public class LowPerformanceProcessor : Processor
    {
        public LowPerformanceProcessor(string model, decimal price, int generation) : base(model, price, generation, 2)
        {
        }
    }
}
