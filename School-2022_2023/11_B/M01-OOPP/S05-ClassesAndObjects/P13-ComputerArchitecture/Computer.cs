using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private string model;
        private int capacity;
        private readonly List<CPU> multiprocessor;

        public Computer(string model, int cappacity)
        {
            Model = model;
            Cappacity = cappacity;
            multiprocessor = new List<CPU>();
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }
        public int Cappacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        public int Count
        {
            get { return multiprocessor.Count; }
        }
        public void Add(CPU cpu)
        {
            if (Count<Cappacity)
            {
                multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            CPU cpu = multiprocessor.FirstOrDefault(x => x.Brand==brand);
            return multiprocessor.Remove(cpu);
        }

        public CPU MostPowerful()
        {
            return multiprocessor.OrderBy(x=>x.Frequency).LastOrDefault();
        }
        public CPU GetCPU(string brand)
        {
            return multiprocessor.FirstOrDefault(x => x.Brand == brand);
        
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            this.multiprocessor.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }


    }
}
