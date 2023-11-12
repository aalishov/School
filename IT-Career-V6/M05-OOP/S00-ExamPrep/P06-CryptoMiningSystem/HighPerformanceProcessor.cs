using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class HighPerformanceProcessor : Processor
    {
        private const int MineMultiplier = 8;
        public HighPerformanceProcessor(string model, double price, int generation) : base(model, price, generation, MineMultiplier)
        {
        }
    }
}
