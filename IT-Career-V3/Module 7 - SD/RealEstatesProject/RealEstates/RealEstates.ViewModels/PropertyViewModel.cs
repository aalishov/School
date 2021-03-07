using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.ViewModels
{
    public class PropertyViewModel
    {
        public int Id { get; set; }
        public string District { get; set; }

        public int Size { get; set; }

        public int Price { get; set; }

        public string Floor { get; set; }

        public string PropertyType { get; set; }

        public int Year { get; set; }

        public ICollection<string> Tags { get; set; }
    }
}
