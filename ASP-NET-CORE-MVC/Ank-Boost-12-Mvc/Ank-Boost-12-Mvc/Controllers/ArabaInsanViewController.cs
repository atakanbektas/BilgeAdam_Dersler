using Ank_Boost_12_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ank_Boost_12_Mvc.Controllers
{
    public class ArabaInsanViewController : Controller
    {
        public IActionResult Index()
        {
            ArabaInsanView ai = new()
            {
                Araba = new Araba("Mercedes CLA", 1900),
                Insan = new() { Ad = "Atakan", yas = 17 }
            };
            return View(ai);
        }
    }
}
