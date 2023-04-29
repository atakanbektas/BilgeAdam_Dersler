using Ank_Boost_12_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ank_Boost_12_Mvc.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            Araba araba = new("Citroen", 1500);

            return View(araba);
        }
    }
}
