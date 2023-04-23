using Asp.Grup1Odev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp.Grup1Odev.Controllers
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
            List<string> personeller = new();
            personeller.Add("Ali");
            personeller.Add("Sağlam");
            personeller.Add("~/../ArabaAli");
            personeller.Add("Ahmet");
            personeller.Add("Serçe");
            personeller.Add("~/../ArabaAhmet");
            personeller.Add("Mehmet");
            personeller.Add("Gün");
            personeller.Add("~/../ArabaMehmet");
            personeller.Add("Hüseyin");
            personeller.Add("Tok");
            personeller.Add("~/../ArabaHuseyin");
            personeller.Add("Alp");
            personeller.Add("Dağ");
            personeller.Add("~/../ArabaAlp");
            personeller.Add("Cem");
            personeller.Add("Yılmaz");
            personeller.Add("~/../ArabaCem");

            return View(personeller);
        }

        public IActionResult DogaArabalar()
        {
            List<string> model = new();
            model.Add("2010");
            model.Add("Tofaş");
            model.Add("2015");
            model.Add("Ford");
            model.Add("2013");
            model.Add("Audi");



            return View(model);
        }

        public IActionResult ArabaAli()
        {
            List<string> model = new();
            model.Add("2015");
            model.Add("Opel");
            model.Add("2003");
            model.Add("Honda");
            return View(model);
        }
        public IActionResult ArabaAhmet()
        {
            List<string> model = new();
            model.Add("1998");
            model.Add("Toyata");
            model.Add("2008");
            model.Add("Peugeot");
            return View(model);
        }
        public IActionResult ArabaMehmet()
        {
            List<string> model = new();
            model.Add("1989");
            model.Add("BMW");
            model.Add("2003");
            model.Add("Mercedes");
            return View(model);
        }
        public IActionResult ArabaHuseyin()
        {
            List<string> model = new();
            model.Add("2022");
            model.Add("Chevrolet");
            model.Add("2020");
            model.Add("Citroen");
            return View(model);
        }
        public IActionResult ArabaAlp()
        {
            List<string> model = new();
            model.Add("2013");
            model.Add("Dacia");
            model.Add("2015");
            model.Add("Renault");
            return View(model);
        }
        public IActionResult ArabaCem()
        {
            List<string> model = new();
            model.Add("2002");
            model.Add("Fiat");
            model.Add("2000");
            model.Add("Ford");
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}