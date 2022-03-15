using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.Data;
using Product.Services;
using Products.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Products.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductsService service = new ProductsService();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            IndexProductsViewModel model = new IndexProductsViewModel();
            model.Products = service.GetProducts()
                .Select(x => new IndexProductViewModel()
                {
                    Name = x.Name,
                    Category = x.Category.Name
                }).ToList();
            model.ProductsCount = service.ProductsCount();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
