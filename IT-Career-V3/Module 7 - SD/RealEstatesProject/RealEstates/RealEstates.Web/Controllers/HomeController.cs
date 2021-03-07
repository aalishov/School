using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstates.Services;
using RealEstates.ViewModels;
using RealEstates.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstates.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPropertiesService propertiesService;

        public HomeController(ILogger<HomeController> logger, IPropertiesService propertiesService)
        {
            _logger = logger;
            this.propertiesService = propertiesService;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                TopCheapest = propertiesService.GetTopChepestPropeties(),
                TopExpesnive = propertiesService.GetTopExpensivePropeties(),
                TopNewest = propertiesService.TopNewestProperties(),
                LastAdded=propertiesService.GetLastAddedProperties(),
            };

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
