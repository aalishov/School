using System.Collections.Generic;

namespace Products.WebApp.Models
{
    public class IndexProductsViewModel
    {
        public ICollection<IndexProductViewModel> Products { get; set; }
        public int ProductsCount { get; set; }
    }
}
