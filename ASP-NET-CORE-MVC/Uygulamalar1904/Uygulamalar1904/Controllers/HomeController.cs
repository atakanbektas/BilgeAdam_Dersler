using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Uygulamalar1904.Models;

namespace Uygulamalar1904.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;




        public IActionResult KelimeAl()
        {
            return View();
        }


        public IActionResult KelimeSonuc(string kelime)
        {
            return View("KelimeSonuc", kelime);
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<int> sayilar = new();
            for (int i = 1; i < 100; i++)
            {
                sayilar.Add(i);
            }
            return View(sayilar);
        }




        [HttpPost]
        public ActionResult Hesapla(int girdi)
        {
            if (girdi % 2 == 0)
            {
                // burada çift sayı için yapılacak işlemleri gerçekleştirin
                ViewBag.Message = girdi.ToString() + " sayısı çifttir.";
            }
            else
            {
                // burada tek sayı için yapılacak işlemleri gerçekleştirin
                ViewBag.Message = girdi.ToString() + " sayısı tektir.";
            }

            return View();
        }




        public IActionResult TekMiCiftMi()
        {
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