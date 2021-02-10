using System;
using System.Collections.Generic;
using System.Text;

namespace _01_DemoFormatException
{
    public class Garage
    {
        private string name;

        public Garage(string name)
        {
            this.Name = name;
            Cars = new List<int>();
        }
        public string Name
        {
            get => name; set
            {
                if (value.Length<3)
                {
                    throw new CustomException("Name exception!");
                }
                name = value;
            }
        }
        public List<int> Cars { get; set; }

    }
}
