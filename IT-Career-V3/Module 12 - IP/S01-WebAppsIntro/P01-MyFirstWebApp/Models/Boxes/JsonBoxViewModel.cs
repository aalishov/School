using P01_MyFirstWebApp.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P01_MyFirstWebApp.Models.Boxes
{
    public class JsonBoxViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int MaxCapacity { get; set; }
        public int CurentCapacity { get; set; }
        public string CurrentCapacitiInfo { get => $"{CurentCapacity}/{MaxCapacity}"; }
        public ICollection<JsonItemViewModel> Items { get; set; }
    }
}
