using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Animals
{
   public class Trainer
    {
        public Trainer(IAnimal animal)
        {
            Animal = animal;
        }

        public IAnimal Animal { get; set; }

        public void Make()
        {
            Animal.Perform();
        }
    }
}
