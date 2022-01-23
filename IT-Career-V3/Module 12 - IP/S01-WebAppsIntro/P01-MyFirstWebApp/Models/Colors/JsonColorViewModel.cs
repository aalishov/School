using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P01_MyFirstWebApp.Models.Colors
{
    public class JsonColorViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ItemInColorViewModel> Items { get; set; }
        public ICollection<BoxInColorViewModel> Boxes { get; set; }
    }
    public class ItemInColorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class BoxInColorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
