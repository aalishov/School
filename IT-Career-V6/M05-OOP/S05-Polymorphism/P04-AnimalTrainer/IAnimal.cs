using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_AnimalTrainer
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        public void Perform();
    }
}
