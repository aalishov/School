using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class LowPerformanceProcessor : Processor
    {
        private const int MineMultiplier = 2;

        public LowPerformanceProcessor(string model, double price, int generation) : base(model, price, generation, MineMultiplier)
        {
        }
    }
}
