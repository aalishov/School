using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P02_Cars.Data.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            this.Models = new List<Model>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Model> Models { get; set; } 
    }
}
