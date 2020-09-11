using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Animals
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        public void Perform();
    }
}
