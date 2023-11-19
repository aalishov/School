using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoClass_v1
{
    public class Product
    {
        public Product(string name, double price, Size size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public Size Size { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Price: {Price:f2}");
            sb.AppendLine($"Size: {Size}");
            return sb.ToString().TrimEnd();
        }
    }


}
