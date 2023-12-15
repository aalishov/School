using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data.Models
{
    public class Car
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();


        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public Engine Engine { get; set; }
    }

    public class Engine
    {
        public string Type { get; set; }
    }
}
