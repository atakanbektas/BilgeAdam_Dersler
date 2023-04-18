using Microsoft.AspNetCore.Mvc;

namespace Asp.CiftTekAsalSayilar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sayilar()
        {
            List<int> sayilar = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return View(sayilar);
        }
        S

    }
}
