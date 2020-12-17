using System;
using System.Collections.Generic;
using System.Text;

namespace P06_ExInheritanceZoo
{
    public class Bear : Mammal
    {
        public Bear(string name) : base(name)
        {
        }
        public int WinterSleepingTime { get; set; }
    }

}
