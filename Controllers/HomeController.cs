using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_core_mvc_sample.Models;

namespace dotnet_core_mvc_sample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "PROFFESIONAL PROFILE.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Information.";

            return View();
        }
        public IActionResult WorkExperience()
        {
            ViewData["Message"] = "WORK EXPERIENCE.";

            return View();
        }
        
        public IActionResult Education()
        {
            ViewData["Message"] = "Education.";

            return View();
        }

        public IActionResult Skills()
        {
            ViewData["Message"] = "Skills.";

            return View();
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
