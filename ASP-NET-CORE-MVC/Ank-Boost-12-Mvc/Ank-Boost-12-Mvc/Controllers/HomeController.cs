using Ank_Boost_12_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ank_Boost_12_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AdSoyle()
        {
            ViewBag.isim = "Atakan2";
            ViewData["ad"] = "Atakan3";
            return View("AdSoyle", "Atakan");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}