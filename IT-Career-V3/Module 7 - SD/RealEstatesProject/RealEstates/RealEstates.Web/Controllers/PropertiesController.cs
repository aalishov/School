using Microsoft.AspNetCore.Mvc;
using RealEstates.Data;
using RealEstates.Services;
using RealEstates.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstates.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly IPropertiesService propertiesService;

        public PropertiesController(IPropertiesService propertiesService)
        {
            this.propertiesService = propertiesService;
        }
        public IActionResult Index(int page=1)
        {
            PropertiesViewModel model = propertiesService.GetProperties(page);
            return View(model);
        }
    }
}
