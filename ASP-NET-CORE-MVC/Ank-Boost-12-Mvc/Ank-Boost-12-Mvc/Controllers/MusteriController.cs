using Ank_Boost_12_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ank_Boost_12_Mvc.Controllers
{
    public class MusteriController : Controller
    {
        public IActionResult Index()
        {

            return View(new Musteri() { Id = 1, SirketAdi = "ata", Email = "ata@gmail.com", GirisTarihi = DateTime.Now.AddDays(-500), Yas = -5 });
        }
    }
}
