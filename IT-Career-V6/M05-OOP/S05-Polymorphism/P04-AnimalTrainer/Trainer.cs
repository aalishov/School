using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_AnimalTrainer
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
