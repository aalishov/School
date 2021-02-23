using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStef.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeachersController:Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
