using CarsCatalogue.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarsCatalogue.Models.Models
{
    public class CreateModelViewModel
    {
        public string Name { get; set; }
        public string BrandId { get; set; }
    }
}
