using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageName = "Dashboard";
            ViewBag.Url = "Dashboard";
            ViewBag.Description = "Home Page";
            return View();
        }
    }
}
